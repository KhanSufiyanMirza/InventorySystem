using demo.Model;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;





namespace demo.classes
{


    class DBAccess
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["patel_motors"].ConnectionString);
        private static SqlCommand command = new SqlCommand();
        // private static SqlDataReader DbReader;
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        // public SqlTransaction DbTran;
        product model = new product();
        Patel_motorsEntities db = new Patel_motorsEntities();




        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {

                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void closeConn()
        {
            connection.Close();
        }


        public int executeDataAdapter(DataTable tblName, string strSelectSql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                adapter.SelectCommand.CommandText = strSelectSql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                SqlCommandBuilder DbCommandBuilder = new SqlCommandBuilder(adapter);


                string insert = DbCommandBuilder.GetInsertCommand().CommandText.ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();


                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void delete_brand_category_tbl(string query, bool a, bool b)
        {
            try
            {

                if (connection.State == 0)
                {
                    createConn();
                }
                if (a)
                {
                    SqlCommand cmd = new SqlCommand("delete from brand where company_brand=@brand", connection);
                    cmd.Parameters.AddWithValue("@brand", query);
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd1 = new SqlCommand("delete from products where brand=@brand", connection);
                    //cmd1.Parameters.AddWithValue("@brand", query);
                    //cmd1.ExecuteNonQuery();



                }
                if (b)
                {
                    SqlCommand cmd = new SqlCommand("delete from category where category=@cat", connection);
                    cmd.Parameters.AddWithValue("@cat", query);
                    cmd.ExecuteNonQuery();
                    //SqlCommand cmd1 = new SqlCommand("delete from products where product_category=@cat1", connection);
                    //cmd1.Parameters.AddWithValue("@cat1", query);
                    //cmd1.ExecuteNonQuery();
                }

                closeConn();


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                closeConn();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable read_adapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;

                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                command.Parameters.Clear();
                closeConn();
                return tblName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public product read_sellingpage_keydown_forRecord(string query, string productName, string product_Brand, string product_Price)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable dt = new DataTable();
                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@pro", productName);
                command.Parameters.AddWithValue("@brand", product_Brand);
                command.Parameters.AddWithValue("@price", product_Price);

                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                product model1 = new product();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        model1.id = Convert.ToInt32(item["id"]);
                        model1.product_name = item["product_name"].ToString();


                        model1.MRP = Convert.ToDecimal(item["MRP"]);
                        model1.Gst = Convert.ToDouble(item["Gst"]);
                        model1.product_quantity = Convert.ToDouble(item["product_quantity"]);
                        model1.Quantity_type = item["Quantity_type"].ToString();
                        model1.base_price = Convert.ToDecimal(item["base_price"].ToString());



                    }

                }

                command.Parameters.Clear();
                closeConn();
                return model1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable read_adapter_sell(string query, string sell, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@gen", sell);

                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                command.Parameters.Clear();
                closeConn();
                return tblName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable read_adapter_sell_purchase(string query, string sell, string product_brand, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@gen", sell);
                command.Parameters.AddWithValue("@brand", product_brand);

                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                command.Parameters.Clear();
                closeConn();
                return tblName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataSet Dataset_data(string query, string pro)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@pro", pro);
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();

                adapter.Fill(ds);

                command.Parameters.Clear();
                closeConn();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public DataTable DatathroughDataAdapter(string query, DataTable tblName, string pro)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.Parameters.AddWithValue("@pro", pro);
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tblName);
                command.Parameters.Clear();
                closeConn();
                return tblName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public void Admin_login(string username, string password, DataTable tblName)
        //{
        //    try
        //    {
        //        if (connection.State == ConnectionState.Closed)
        //        {
        //            createConn();
        //        }
        //        SqlCommand cmd = connection.CreateCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "select * from admin_login where username= @user and pass= @password";
        //        cmd.Parameters.AddWithValue("@user", username);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        cmd.ExecuteNonQuery();


        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tblName);





        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public void Read_Data(string username, string password, DataTable tblName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }


                //SqlCommand cmd = new SqlCommand("select * from admin_login where username=@Name and pass=@password", connection);
                //cmd.Parameters.AddWithValue("@user", username.ToString());
                //cmd.Parameters.AddWithValue("@password", password.ToString());

                //cmd.Parameters.Add(new SqlParameter("@Name", username);
                //cmd.Parameters.Add(new SqlParameter("@password", password);

                // cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter("select * from admin_login where username=@Name and pass=@password", connection);
                //da.SelectCommand.Parameters.AddWithValue("@Name", username);
                //da.SelectCommand.Parameters.AddWithValue("@password", password);
                //da.Fill(tblName);
                adapter = new SqlDataAdapter("select * from admin_login where username=@Name and pass=@password", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", username);
                adapter.SelectCommand.Parameters.AddWithValue("@password", password);
                adapter.Fill(tblName);
                adapter.SelectCommand.Parameters.Clear();
                closeConn();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool selling_product_exist_changing_latest_selling_p(string Product_id, string party_name, string latest_selling_price)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();
                bool yes = false;
                SqlCommand cmd = new SqlCommand("update selling_product_table set sell_price=@selling where product_id=@pid and Party_name=@party ", connection);

                cmd.Parameters.AddWithValue("@pid", Product_id);
                cmd.Parameters.AddWithValue("@party", party_name);
                cmd.Parameters.AddWithValue("@selling", latest_selling_price);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    yes = true;
                }
                closeConn();
                return yes;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool product_exist_changing_stock_quantity(string ProductName, string product_brand, string party, string qty, string latest_purchase_price, string latest_selling_price, string latestbasic_p, string latest_gst, string latest_mrp)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();
                bool yes = false;

                adapter = new SqlDataAdapter("select top 1 *  from products where product_name=@name and brand=@brand and product_category=@cat order by id desc ", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@name", ProductName);
                adapter.SelectCommand.Parameters.AddWithValue("@brand", product_brand);
                adapter.SelectCommand.Parameters.AddWithValue("@cat", party);

                adapter.Fill(tblName);
                if (tblName.Rows.Count > 0)
                {
                    int pid = 0;
                    yes = true;
                    foreach (DataRow item in tblName.Rows)
                    {
                        pid = Convert.ToInt32(item["id"].ToString());
                        break;
                    }
                    SqlCommand cmd = new SqlCommand("update products set product_quantity=product_quantity+@qty ,purchase_price=@purchase_price,sell_price=@sell_price ,base_price=@base,Gst=@gst,MRP=@mrp where id='" + pid + "' ", connection);
                    cmd.Parameters.AddWithValue("@qty", qty);
                    cmd.Parameters.AddWithValue("@purchase_price", latest_purchase_price);
                    cmd.Parameters.AddWithValue("@sell_price", latest_selling_price);
                    cmd.Parameters.AddWithValue("@base", latestbasic_p);
                    cmd.Parameters.AddWithValue("@gst", latest_gst);
                    cmd.Parameters.AddWithValue("@mrp", latest_mrp);
                    cmd.ExecuteNonQuery();
                }

                adapter.SelectCommand.Parameters.Clear();
                closeConn();
                return yes;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool product_exist(string product_name, string product_brand, string cat, string purchase_price, string sell_price, string qty, string invoice)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();
                bool yes = false;

                adapter = new SqlDataAdapter("select * from products where product_name=@Name and brand=@brand and product_category=@cat and purchase_price=@price and sell_price=@sell", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", product_name);
                adapter.SelectCommand.Parameters.AddWithValue("@brand", product_brand);
                adapter.SelectCommand.Parameters.AddWithValue("@cat", cat);
                adapter.SelectCommand.Parameters.AddWithValue("@price", purchase_price);
                adapter.SelectCommand.Parameters.AddWithValue("@sell", sell_price);

                adapter.Fill(tblName);
                if (tblName.Rows.Count > 0)
                {
                    int id = 0;
                    yes = true;
                    foreach (DataRow item in tblName.Rows)
                    {
                        id = Convert.ToInt32(item["id"].ToString());
                        break;
                    }
                    if (id > 0)
                    {
                        SqlCommand cmd = new SqlCommand("update products set product_quantity=product_quantity+@qty,invoice=@invo where id=@id");
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@invo", id);
                        DBAccess objdb = new DBAccess();
                        objdb.executeQuery(cmd);
                        // db.products.SqlQuery("update products set product_quantity=product_quantity+@qty,invoice=@invo", new SqlParameter("@qty", qty),new SqlParameter("@invo",invoice));
                    }
                }

                adapter.SelectCommand.Parameters.Clear();
                closeConn();
                return yes;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool product_exist(string product_name, string product_brand, string purchase_price)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();
                bool yes = false;

                adapter = new SqlDataAdapter("select * from products where product_name=@Name and brand=@brand  and purchase_price < @price ", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", product_name);
                adapter.SelectCommand.Parameters.AddWithValue("@brand", product_brand);

                adapter.SelectCommand.Parameters.AddWithValue("@price", purchase_price);

                adapter.Fill(tblName);
                adapter.SelectCommand.Parameters.Clear();
                closeConn();
                if (tblName.Rows.Count > 0)
                {
                    yes = true;
                }


                return yes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public product product_exist_msg(string product_name, string product_brand)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();
                product model2 = new product();
                decimal price = 0;
                adapter = new SqlDataAdapter("select Min(purchase_price) from products where product_name = @product and brand = @pro_brand", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@product", product_name);
                adapter.SelectCommand.Parameters.AddWithValue("@pro_brand", product_brand);
                adapter.Fill(tblName);
                if (tblName.Rows.Count > 0)
                {
                    foreach (DataRow item in tblName.Rows)
                    {
                        price = Convert.ToDecimal(item["Column1"]);
                    }

                    tblName.Clear();
                    adapter.SelectCommand.Parameters.Clear();

                    adapter = new SqlDataAdapter("select * from products where purchase_price =@price and product_name = @product and brand = @pro_brand", connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@product", product_name);
                    adapter.SelectCommand.Parameters.AddWithValue("@pro_brand", product_brand);
                    adapter.SelectCommand.Parameters.AddWithValue("@price", price.ToString());
                    adapter.Fill(tblName);
                    adapter.SelectCommand.Parameters.Clear();
                    closeConn();
                    if (tblName.Rows.Count > 0)
                    {
                        foreach (DataRow item in tblName.Rows)
                        {
                            model2.product_category = item["product_category"].ToString();
                            model2.product_name = item["product_name"].ToString();
                            model2.purchase_price = Convert.ToDecimal(item["purchase_price"]);
                            model2.brand = item["brand"].ToString();

                        }
                    }

                }


                return model2;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable product_exist_sell(string product_name, string product_brand, string purchase_price, string party)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                DataTable tblName = new DataTable();


                adapter = new SqlDataAdapter("select * from selling_product_table where product_name=@Name and brand=@brand  and purchase_price=@price and Party_name=@party", connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", product_name);
                adapter.SelectCommand.Parameters.AddWithValue("@brand", product_brand);

                adapter.SelectCommand.Parameters.AddWithValue("@price", purchase_price);
                adapter.SelectCommand.Parameters.AddWithValue("@party", party);
                adapter.Fill(tblName);
                adapter.SelectCommand.Parameters.Clear();
                closeConn();



                return tblName;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader readDatathroughReader(string query)
        {
            //DataReader used to sequentially read data from a data source
            SqlDataReader reader;

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();

                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int executeQuery(SqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }

                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;


                return dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}
