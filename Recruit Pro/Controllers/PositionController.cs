using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Recruit_Pro.Models;
using Recruit_Pro.Models.enums__for_handling_lookups_;
using System.Data;

namespace Recruit_Pro.Controllers
{
    public class PositionController : Controller
    {
        public IActionResult Index()
        {
            List<Position> positionList = new List<Position>();
            string query = "SELECT * FROM job_position p LEFT JOIN position_district pd ON p.position_id = pd.position_id  LEFT JOIN position_location pl ON p.position_id = pl.position_id LEFT JOIN position_province pp ON p.position_id = pp.position_id LEFT JOIN qualification q ON p.position_id = q.position_id LEFT JOIN lookup l1 ON l1.lookup_id = p.gender LEFT JOIN lookup l2 ON l2.lookup_id = p.status";
            DataTable dt = SqlHelper.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                positionList.Add(new Position
                {
                    position_id = Convert.ToInt32(row["position_id"]),
                    title = row["title"].ToString() ?? null!,
                    department = row["department"].ToString() ?? null!,
                    description = (row["description"] == DBNull.Value) ? "" : row["description"].ToString(),
                    gender = (row["gender"] == DBNull.Value) ? null : (GenderType)row["gender"],
                    responsibilities = (row["responsibilities"] == DBNull.Value) ? "" : row["responsibilities"].ToString(),
                    domicile = (row["domicile"] == DBNull.Value) ? "" : row["domicile"].ToString(),
                    starting_salary = (row["starting_salary"] == DBNull.Value) ? -1 : Convert.ToInt32(row["starting_Salary"].ToString()),
                    maximum_salary = (row["maximum_salary"] == DBNull.Value) ? -1 : Convert.ToInt32(row["maximum_salary"].ToString()),
                    scale = (row["scale"] == DBNull.Value) ? "" : row["scale"].ToString(),
                    minimum_age = (row["minimum_age"] == DBNull.Value) ? -1 : Convert.ToInt32(row["minimum_age"].ToString()),
                    maximum_age = (row["minimum_age"] == DBNull.Value) ? -1 : Convert.ToInt32(row["minimum_age"].ToString()),
                    status= Convert.ToInt32(row["status"].ToString()),
                    remarks = (row["remarks"] == DBNull.Value) ? "" : row["remarks"].ToString()
                });
            }
            return View(positionList);
        }
    
        public IActionResult Create()
        {
            Position position = null!;
            return View("PositionForm",position);
        }

        [HttpPost]
        public IActionResult Create(IFormCollection form) // AI Generated Controller Function But 80 % understandable, needs some improvements
        {
            // Map form values to Position model
            var model = new Position();
            model.title = form["title"].ToString();
            model.department = form["department"].ToString();
            model.description = form["description"].ToString();
            model.responsibilities = form["responsibilities"].ToString();
            model.domicile = form["domicile"].ToString();
            model.scale = form["scale"].ToString();
            model.remarks = form["remarks"].ToString();

            // Parse numeric values safely
            if (int.TryParse(form["starting-salary"], out var s)) model.starting_salary = s;
            if (int.TryParse(form["maximum-salary"], out var m)) model.maximum_salary = m;
            if (int.TryParse(form["minimum-age"], out var minA)) model.minimum_age = minA;
            if (int.TryParse(form["maximum-age"], out var maxA)) model.maximum_age = maxA;

            // Map status/gender to integers. Adjust mapping if your lookup table uses different ids.
            var genderValue = form["gender"].ToString().ToLower();

            var statusValue = form["status"].ToString().ToLower();
            model.status = statusValue == "active" ? 1 : 0;

            // Insert into job_position table
            string query = @"INSERT INTO job_position
                                (title, department, description, gender, responsibilities, domicile, starting_salary, maximum_salary, scale, minimum_age, maximumAge, status, remarks)
                                VALUES
                                (@title, @department, @description, @gender, @responsibilities, @domicile, @starting_salary, @maximum_salary, @scale, @minimum_age, @maximumAge        , @status, @remarks);";

            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@title", string.IsNullOrEmpty(model.title) ? (object)DBNull.Value : model.title),
                new MySqlParameter("@department", string.IsNullOrEmpty(model.department) ? (object)DBNull.Value : model.department),
                new MySqlParameter("@description", string.IsNullOrEmpty(model.description) ? (object)DBNull.Value : model.description),
                new MySqlParameter("@gender", model.gender.HasValue ? (object)model.gender.Value : (object)DBNull.Value),
                new MySqlParameter("@responsibilities", string.IsNullOrEmpty(model.responsibilities) ? (object)DBNull.Value : model.responsibilities),
                new MySqlParameter("@domicile", string.IsNullOrEmpty(model.domicile) ? (object)DBNull.Value : model.domicile),
                new MySqlParameter("@starting_salary", model.starting_salary.HasValue ? (object)model.starting_salary.Value : (object)DBNull.Value),
                new MySqlParameter("@maximum_salary", model.maximum_salary.HasValue ? (object)model.maximum_salary.Value : (object)DBNull.Value),
                new MySqlParameter("@scale", string.IsNullOrEmpty(model.scale) ? (object)DBNull.Value : model.scale),
                new MySqlParameter("@minimum_age", model.minimum_age.HasValue ? (object)model.minimum_age.Value : (object)DBNull.Value),
                new MySqlParameter("@maximum_age", model.maximum_age.HasValue ? (object)model.maximum_age.Value : (object)DBNull.Value),
                new MySqlParameter("@status", model.status),
                new MySqlParameter("@remarks", string.IsNullOrEmpty(model.remarks) ? (object)DBNull.Value : model.remarks)
            };

            try
            {
                SqlHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting position: {ex.Message}");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            string query = "DELETE FROM job_position WHERE position_id = @position_id;";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@position_id", id)
            };
            try
            {
                SqlHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error deleting position with ID {id}: {ex.Message}");
            }
                return RedirectToAction("Index");
        }
        

    }
}
