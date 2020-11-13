using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReceitaRepository
    {
        List<Recipe> GetAll()
        {
            List<Recipe> temp = new List<Recipe>();

            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spSearchRecipe";
                cmd.CommandType = CommandType.StoredProcedure;


                conn.Open();


                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Recipe Recipe = new Recipe()
                    {
                        Id = dr.GetInt32(0),

                    };

                    temp.Add(Recipe);
                }
            }

            return temp;
        }

        public Recipe GetById(int id)
        {

        }

        public void Add(Recipe recipe)
        {
            using (SqlConnection conn = new SqlConnection(_cs))
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "spAddRecipe";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Title", recipe.Title);

                // output
                SqlParameter idParam = new SqlParameter();
                idParam.ParameterName = "@ProductId";
                idParam.SqlDbType = SqlDbType.Int;
                idParam.Direction = ParameterDirection.Output; // output

                cmd.Parameters.Add(idParam);

                conn.Open();

                int affectedRows = cmd.ExecuteNonQuery();

                Console.WriteLine(cmd.CommandText);

                if (affectedRows == 1)
                {
                    int id = (int)idParam.Value;

                    recipe.Id = id;
                }
                else
                {
                    throw new Exception()
        }

        public void Remove(int id)
        {

        }

        public void Update(Recipe recipe)
        {

        }
    }
}
