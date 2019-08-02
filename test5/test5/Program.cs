using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test5
{
    class Program
    {

        public static DataTable SUM_ITEM_TRN_empty_table()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("CONVERT_NO");
            dt.Columns.Add("LINE_NO");
            dt.Columns.Add("COMM_STATUS");
            dt.Columns.Add("STORE_KBN");
            dt.Columns.Add("STORE_CD");
            dt.Columns.Add("POS_NO");
            dt.Columns.Add("EIGYOU_DATE");
            dt.Columns.Add("SEISAN_NO");
            dt.Columns.Add("SEISAN_CNT");
            dt.Columns.Add("RECEIPT_NO");
            dt.Columns.Add("ITEM_KBN");
            dt.Columns.Add("PROC1_KBN");
            dt.Columns.Add("PROC2_KBN");
            dt.Columns.Add("ITEM_CD");
            dt.Columns.Add("UNIT_PRICE");
            dt.Columns.Add("SALES_NUM");
            dt.Columns.Add("TAX_KBN");
            dt.Columns.Add("SALES1_PRICE");
            dt.Columns.Add("SALES2_PRICE");
            dt.Columns.Add("DISCOUNT1_PRICE");
            dt.Columns.Add("DISCOUNT2_PRICE");
            dt.Columns.Add("SALES_WEIGHT");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("HAKARI_KBN");
            dt.Columns.Add("SYU_DATE");
            dt.Columns.Add("JIKAN_KBN");
            dt.Columns.Add("DISCOUNT_PRICE_JS");
            dt.Columns.Add("SALES_NUM_TC");
            dt.Columns.Add("SALES_PRICE_TC");
            dt.Columns.Add("SALES_WEIGHT_TC");
            dt.Columns.Add("DISCOUNT_NUM");
            dt.Columns.Add("URI_GENKA");
            dt.Columns.Add("RE_GOODS_KBN");
            dt.Columns.Add("REDUCED_TAX_KBN");
            dt.Columns.Add("KIKAN_FLG");

            return dt;

        }

        public static DataTable add_data_to_SUM_ITEM_TRN(DataSet XML_rcd, int i)
        {
            DataTable SUM_ITEM_TRN_dt = SUM_ITEM_TRN_empty_table();

            DataRow row = SUM_ITEM_TRN_dt.NewRow();
            row["CONVERT_NO"] = SUM_ITEM_TRN_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_ITEM_TRN_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_ITEM_TRN_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_ITEM_TRN_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_ITEM_TRN_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_ITEM_TRN_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_ITEM_TRN_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_ITEM_TRN_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_ITEM_TRN_field_SEISAN_CNT(XML_rcd);
            row["RECEIPT_NO"] = SUM_ITEM_TRN_field_RECEIPT_NO(XML_rcd);
            row["ITEM_KBN"] = SUM_ITEM_TRN_field_ITEM_KBN(XML_rcd);
            row["PROC1_KBN"] = SUM_ITEM_TRN_field_PROC1_KBN(XML_rcd);
            row["PROC2_KBN"] = SUM_ITEM_TRN_field_PROC2_KBN(XML_rcd);
            row["ITEM_CD"] = SUM_ITEM_TRN_field_ITEM_CD(XML_rcd);
            row["UNIT_PRICE"] = SUM_ITEM_TRN_field_UNIT_PRICE(XML_rcd);
            row["SALES_NUM"] = SUM_ITEM_TRN_field_SALES_NUM(XML_rcd, i);
            row["TAX_KBN"] = SUM_ITEM_TRN_field_TAX_KBN(XML_rcd);
            row["SALES1_PRICE"] = SUM_ITEM_TRN_field_SALES1_PRICE(XML_rcd);
            row["SALES2_PRICE"] = SUM_ITEM_TRN_field_SALES2_PRICE(XML_rcd);
            row["DISCOUNT1_PRICE"] = SUM_ITEM_TRN_field_DISCOUNT1_PRICE(XML_rcd, i);
            row["DISCOUNT2_PRICE"] = SUM_ITEM_TRN_field_DISCOUNT2_PRICE(XML_rcd, i);
            row["SALES_WEIGHT"] = SUM_ITEM_TRN_field_SALES_WEIGHT(XML_rcd);
            row["CREATE_DATETIME"] = SUM_ITEM_TRN_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_ITEM_TRN_field_UPDATE_DATETIME(XML_rcd);
            row["HAKARI_KBN"] = SUM_ITEM_TRN_field_HAKARI_KBN(XML_rcd);
            row["SYU_DATE"] = SUM_ITEM_TRN_field_SYU_DATE(XML_rcd);
            row["JIKAN_KBN"] = SUM_ITEM_TRN_field_JKAN_KBN(XML_rcd);
            row["DISCOUNT_PRICE_JS"] = SUM_ITEM_TRN_field_DISCOUNT_PRICE_JS(XML_rcd);
            row["SALES_NUM_TC"] = SUM_ITEM_TRN_field_SALES_NUM_TC(XML_rcd);
            row["SALES_PRICE_TC"] = SUM_ITEM_TRN_field_SALES_PRICE_TC(XML_rcd);
            row["SALES_WEIGHT_TC"] = SUM_ITEM_TRN_field_SALES_WEIGHT_TC(XML_rcd);
            row["DISCOUNT_NUM"] = SUM_ITEM_TRN_field_DISCOUNT_NUM(XML_rcd);
            row["URI_GENKA"] = SUM_ITEM_TRN_field_URI_GENKA(XML_rcd);
            row["RE_GOODS_KBN"] = SUM_ITEM_TRN_field_RE_GOODS_KBN(XML_rcd);
            row["REDUCED_TAX_KBN"] = SUM_ITEM_TRN_field_REDUCAD_TAX_KBN(XML_rcd);
            row["KIKAN_FLG"] = SUM_ITEM_TRN_field_KIKAN_FLG(XML_rcd);
            SUM_ITEM_TRN_dt.Rows.Add(row);

            return SUM_ITEM_TRN_dt;
        }

        public static void do_insert(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection connn = new SqlConnection(sqlcon);
            connn.Open();

            DataTable SUM_ITEM_TRN_dt = add_data_to_SUM_ITEM_TRN(XML_rcd, i);

            string sql_insert = "INSERT INTO SUM_ITEM_TRN ( CONVERT_NO, LINE_NO, COMM_STATUS, STORE_KBN, STORE_CD, POS_NO, EIGYOU_DATE, SEISAN_NO, SEISAN_CNT, RECEIPT_NO, ITEM_KBN, PROC1_KBN, PROC2_KBN, ITEM_CD, UNIT_PRICE, SALES_NUM, TAX_KBN, SALES1_PRICE, SALES2_PRICE, DISCOUNT1_PRICE, DISCOUNT2_PRICE, SALES_WEIGHT, CREATE_DATETIME, UPDATE_DATETIME, HAKARI_KBN, SYU_DATE, JIKAN_KBN, DISCOUNT_PRICE_JS, SALES_NUM_TC, SALES_PRICE_TC, SALES_WEIGHT_TC, DISCOUNT_NUM, URI_GENKA, RE_GOODS_KBN, REDUCED_TAX_KBN, KIKAN_FLG ) VALUES ("
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["LINE_NO"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["STORE_CD"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["POS_NO"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["RECEIPT_NO"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["ITEM_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["PROC1_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["PROC2_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["ITEM_CD"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["UNIT_PRICE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES_NUM"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["TAX_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES1_PRICE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES2_PRICE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["DISCOUNT1_PRICE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["DISCOUNT2_PRICE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES_WEIGHT"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["HAKARI_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SYU_DATE"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["JIKAN_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["DISCOUNT_PRICE_JS"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES_NUM_TC"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES_PRICE_TC"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["SALES_WEIGHT_TC"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["DISCOUNT_NUM"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["URI_GENKA"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["RE_GOODS_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["REDUCED_TAX_KBN"].ToString() + "', "
                             + "'" + SUM_ITEM_TRN_dt.Rows[0]["KIKAN_FLG"].ToString() + "' "
                        + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert, connn);
            cmd.ExecuteNonQuery();
            connn.Close();

            //Console.WriteLine(sql_insert);
            //Console.ReadLine();
        }


        public static int Line_no()
        {
            int line_no_int = -1;
            string sqlconn = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection conn = new SqlConnection(sqlconn);

            conn.Open();
            DataTable XML_DataTable = new DataTable();
            string sql = "SELECT max(LINE_NO) as Line_no FROM SUM_ITEM_TRN";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            dataAdapter.Fill(XML_DataTable);
            string line_no = XML_DataTable.Rows[0]["Line_no"].ToString();
            if (!line_no.Equals("")) line_no_int = Convert.ToInt32(line_no);

            return line_no_int;
        }

        public static int get_seq_no(int count_loop)
        {
            int seq_no = count_loop * 100;

            return seq_no;
        }

        static void Main(string[] args)
        {
            string sqlconn = @"Data Source=NXPHU-DEV;Initial Catalog=pos_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection conn = new SqlConnection(sqlconn);

            conn.Open();


            bool select_loop = true;
            int count_loop = 0;




            while (select_loop)
            {
                DataTable XML_DataTable = new DataTable();

                string sql = "SELECT top (100) log_data FROM t_pure_log where seq_no >= " + get_seq_no(count_loop).ToString();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
                dataAdapter.Fill(XML_DataTable);
                count_loop++;
                if (XML_DataTable.Rows.Count < 100) select_loop = false;

                int latest_line_no = Line_no();

                for (int i = latest_line_no + 1; i < (XML_DataTable.Rows.Count + latest_line_no + 1); i++)
                {

                    StringReader theReader = new StringReader(XML_DataTable.Rows[i - latest_line_no - 1]["log_data"].ToString());
                    DataSet XML_rcd = new DataSet();
                    XML_rcd.ReadXml(theReader);


                    //thuc hien insert


                    do_insert(XML_rcd, i);
                    insert_dataTotal.do_insert_SUM_TOTALTRN(XML_rcd, i);
                    insert_dataMoney.do_insert_SUM_MONEY(XML_rcd, i);
                    insert_dataTend.do_insert_SUM_TENDTRN(XML_rcd, i);
                    insert_dataLost.do_insert_SUM_LOSTDAT(XML_rcd, i);
                    insert_dataPosDat.do_insert_SUM_POSDAT(XML_rcd, i);
                }
            }
            conn.Close();
            Console.WriteLine("Insert SUCCESS!!!");
            Console.ReadLine();
        }
        public static string SUM_ITEM_TRN_field_CONVERT_NO(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_LINE_NO(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                ret = i.ToString();
                return ret;
                ///Xử lí logic
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_COMM_STATUS(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_STORE_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_STORE_CD(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["h_h"] != null)
                {
                    for (int j = 0; j < XML_rcd.Tables["h_h"].Rows.Count; j++)
                    {
                        string str = XML_rcd.Tables["H_H"].Rows[j]["ith_misecode"].ToString();
                        if (str.Length == 4)
                        {
                            if (str.Substring(0, 1) == "0" || str.Substring(0, 1) == "1")
                            {
                                ret = "0" + str;
                            }
                            else if (str.Substring(0, 1) == "2" || str.Substring(0, 1) == "3")
                            {
                                ret = str.Substring(0, 1) + "0" + str.Substring(1, 3);
                            }
                            else
                            {
                                ret = str.Substring(0, 2) + "0" + str.Substring(2, 2);
                            }
                        }
                        else if (str.Length < 4)
                        {

                            if (str.Length == 0)
                            {
                                ret = "00000";
                            }
                            else if (str.Length == 1)
                            {
                                ret = "0000" + str;
                            }
                            else if (str.Length == 2)
                            {
                                ret = "000" + str;
                            }
                            else
                            {
                                ret = "00" + str;
                            }
                        }
                        else
                        {
                            string a = str.Substring(str.Length - 5, 5);
                            ret = a;
                        }
                    }
                }
                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_POS_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_EIGYOU_DATE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SEISAN_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SEISAN_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_RECEIPT_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_ITEM_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = "M";
                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_PROC1_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_PROC2_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_ITEM_CD(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_UNIT_PRICE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES_NUM(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        string iM_KeiryoFlg = XML_rcd.Tables["M_U"].Rows[i]["iM_KeiryoFlg"].ToString();
                        double num = 0;
                        if (iM_KeiryoFlg == "1") num = 1;
                        else
                        {
                            num = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["iM_Suryo"].ToString());
                        }
                        if (XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString().Substring(0, 1) == "0"
                           || XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString().Substring(0, 1) == "3")
                        {
                            ret = num.ToString();
                        }
                        else ret = (num * (-1)).ToString();


                        ret = ret.Replace(",", "");
                        if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 8);
                        }
                        else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 7);
                        }
                    }
                }
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_TAX_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES1_PRICE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES2_PRICE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_DISCOUNT1_PRICE(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        double Goka = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["lM_Goka"].ToString());
                        double GokaNbkMae = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["lM_GokaNbkMae"].ToString());
                        double Zeiritu = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["dM_Zeiritu"].ToString());
                        double final = 0;

                        if (XML_rcd.Tables["M_U"].Rows[i]["iM_ZeiKbn"].ToString().Equals("0"))
                        {

                            final = (GokaNbkMae - Goka) - Math.Floor(((GokaNbkMae - Goka) * Zeiritu / (100 + Zeiritu)));
                        }

                        else if (XML_rcd.Tables["M_U"].Rows[i]["iM_ZeiKbn"].ToString().Equals("1"))
                        {
                            final = GokaNbkMae - Goka;
                        }

                        if (XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString().Substring(0, 1) == "0"
                         || XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString().Substring(0, 1) == "3")
                        {

                            ret = final.ToString();

                        }
                        else ret = (final * (-1)).ToString();

                        ret = ret.Replace(",", "");


                        if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 8);
                        }
                        else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 7);
                        }
                    }
                }
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_DISCOUNT2_PRICE(DataSet XML_rcd, int i)
        {
            string ret = "0";
            ret = SUM_ITEM_TRN_field_DISCOUNT1_PRICE(XML_rcd, i);
            return ret;
        }

        public static string SUM_ITEM_TRN_field_SALES_WEIGHT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_CREATE_DATETIME(DataSet XML_rcd)
        {
            string ret = "19000101 00:00:00";
            try
            {
                ret = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_UPDATE_DATETIME(DataSet XML_rcd)
        {
            string ret = "19000101 00:00:00";
            try
            {
                ret = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_HAKARI_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SYU_DATE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_JKAN_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_DISCOUNT_PRICE_JS(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES_NUM_TC(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES_PRICE_TC(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_SALES_WEIGHT_TC(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_DISCOUNT_NUM(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_URI_GENKA(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_RE_GOODS_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_REDUCAD_TAX_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_ITEM_TRN_field_KIKAN_FLG(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                return ret;
            }

            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }
    }
}
