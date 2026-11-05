using System.Data.OleDb;
using System.Security.Cryptography;

namespace Login_Sign_in
{
    public static class Db
    {
        private static string ConnStr =>
            $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "LGSI.accdb")};";

        private const int Iterations = 100_000;

        private static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
            return Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        private static bool Verify(string password, string stored)
        {
            var parts = stored.Split(':');
            if (parts.Length != 2) return false;
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] expected = Convert.FromBase64String(parts[1]);
            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }

        public static bool Exists(string userName, string email)
        {
            using var conn = new OleDbConnection(ConnStr);
            using var cmd = new OleDbCommand(
                "SELECT COUNT(*) FROM Table1 WHERE UserName = ? OR Email = ?", conn);
            cmd.Parameters.AddWithValue("?", userName);
            cmd.Parameters.AddWithValue("?", email);
            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public static void Register(string userName, string email, string password)
        {
            using var conn = new OleDbConnection(ConnStr);
            using var cmd = new OleDbCommand(
                "INSERT INTO Table1 (UserName, Email, PasswordHash) VALUES (?, ?, ?)", conn);
            cmd.Parameters.AddWithValue("?", userName);
            cmd.Parameters.AddWithValue("?", email);
            cmd.Parameters.AddWithValue("?", HashPassword(password));
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static bool Login(string userName, string password)
        {
            using var conn = new OleDbConnection(ConnStr);
            using var cmd = new OleDbCommand(
                "SELECT PasswordHash FROM Table1 WHERE UserName = ?", conn);
            cmd.Parameters.AddWithValue("?", userName);
            conn.Open();
            var result = cmd.ExecuteScalar() as string;
            return result != null && Verify(password, result);
        }

        public static bool ResetPassword(string userName, string email, string newPassword)
        {
            using var conn = new OleDbConnection(ConnStr);
            using var cmd = new OleDbCommand(
                "UPDATE Table1 SET PasswordHash = ? WHERE UserName = ? AND Email = ?", conn);
            cmd.Parameters.AddWithValue("?", HashPassword(newPassword));
            cmd.Parameters.AddWithValue("?", userName);
            cmd.Parameters.AddWithValue("?", email);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}