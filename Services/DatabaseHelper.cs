using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace McIntyresFitnessApp.Services
{
    public class DatabaseHelper
    {
        private string connectionString =
            "server=localhost;database=mcintyrefitness;uid=root;pwd=root;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Hashes a plain text password using SHA256.
        /// </summary>
        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        /// <summary>
        /// Inserts a new user record into the Users table.
        /// </summary>
        public bool RegisterUser(string username, string password)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, PasswordHash) VALUES (@username, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", HashPassword(password));
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }

        /// <summary>
        /// Inserts a new workout record into the Workouts table.
        /// </summary>
        public bool AddWorkout(int userId, string exercise, int sets, int reps, decimal weight)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Workouts 
        (UserID, ExerciseName, Sets, Reps, Weight, WorkoutDate)
        VALUES (@userId, @exercise, @sets, @reps, @weight, NOW())";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@exercise", exercise);
                    cmd.Parameters.AddWithValue("@sets", sets);
                    cmd.Parameters.AddWithValue("@reps", reps);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Retrieves all workouts for a given user ordered by date.
        /// </summary>
        public DataTable GetWorkouts(int userId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT WorkoutID, ExerciseName, Sets, Reps, Weight, WorkoutDate
                         FROM Workouts
                         WHERE UserID = @userId
                         ORDER BY WorkoutDate DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves workouts for a given user within a specified date range.
        /// </summary>
        public DataTable GetWorkoutsByDate(int userId, DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT WorkoutID, ExerciseName, Sets, Reps, Weight, WorkoutDate
                         FROM Workouts
                         WHERE UserID = @userId
                         AND WorkoutDate BETWEEN @startDate AND @endDate
                         ORDER BY WorkoutDate DESC";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1));
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        /// <summary>
        /// Deletes a workout record from the database by ID.
        /// </summary>
        public bool DeleteWorkout(int workoutId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Workouts WHERE WorkoutID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", workoutId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Updates an existing workout record with new values.
        /// </summary>
        public bool UpdateWorkout(int workoutId, string exercise, int sets, int reps, decimal weight)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Workouts
                         SET ExerciseName = @exercise,
                             Sets = @sets,
                             Reps = @reps,
                             Weight = @weight
                         WHERE WorkoutID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", workoutId);
                    cmd.Parameters.AddWithValue("@exercise", exercise);
                    cmd.Parameters.AddWithValue("@sets", sets);
                    cmd.Parameters.AddWithValue("@reps", reps);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        /// <summary>
        /// Returns the total number of workouts logged by the user.
        /// </summary>
        public int GetTotalWorkouts(int userId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Workouts WHERE UserID = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Calculates the total weight lifted by multiplying sets, reps, and weight for all workouts.
        /// </summary>
        public decimal GetTotalWeightLifted(int userId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT IFNULL(SUM(Weight * Sets * Reps), 0)
                         FROM Workouts
                         WHERE UserID = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Returns the heaviest weight the user has ever lifted.
        /// </summary>
        public decimal GetMaxWeight(int userId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT IFNULL(MAX(Weight), 0)
                         FROM Workouts
                         WHERE UserID = @userId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }

        /// <summary>
        /// Returns the exercise the user has logged most frequently.
        /// </summary>
        public string GetFavoriteExercise(int userId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"SELECT ExerciseName
                         FROM Workouts
                         WHERE UserID = @userId
                         GROUP BY ExerciseName
                         ORDER BY COUNT(*) DESC
                         LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "None";
                }
            }
        }
    }
}