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
    class insert_dataMoney
    {
        public static DataTable SUM_MONEY_DAT_empty_table()
        {
            DataTable dt = new DataTable();
            //string sql_org = "select * from SUM_MONEY_DAT";
            //SqlDataAdapter adataAdapter = new SqlDataAdapter(sql_org, connn);
            //adataAdapter.Fill(dt);
            dt.Columns.Add("CONVERT_NO");
            dt.Columns.Add("LINE_NO");
            dt.Columns.Add("COMM_STATUS");
            dt.Columns.Add("STORE_KBN");
            dt.Columns.Add("STORE_CD");
            dt.Columns.Add("POS_NO");
            dt.Columns.Add("EIGYOU_DATE");
            dt.Columns.Add("SEISAN_NO");
            dt.Columns.Add("SEISAN_CNT");
            dt.Columns.Add("COMM_KBN");
            dt.Columns.Add("KAMOKU_CD");
            dt.Columns.Add("NYU_SHUKIN_CD");
            dt.Columns.Add("NYU_SHUKIN_CNT");
            dt.Columns.Add("NYU_SHUKIN_KIN");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("KIKAN_FLG");

            return dt;

        }

        public static DataTable add_data_to_SUM_MONEY_DAT(DataSet XML_rcd, int i)
        {
            DataTable SUM_MONEY_DAT_dt = SUM_MONEY_DAT_empty_table();

            DataRow row = SUM_MONEY_DAT_dt.NewRow();
            row["CONVERT_NO"] = SUM_MONEY_DAT_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_MONEY_DAT_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_MONEY_DAT_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_MONEY_DAT_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_MONEY_DAT_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_MONEY_DAT_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_MONEY_DAT_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_MONEY_DAT_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_MONEY_DAT_field_SEISAN_CNT(XML_rcd);
            row["COMM_KBN"] = SUM_MONEY_DAT_field_COMM_KBN(XML_rcd);
            row["KAMOKU_CD"] = SUM_MONEY_DAT_field_KAMOKU_CD(XML_rcd);
            row["NYU_SHUKIN_CD"] = SUM_MONEY_DAT_field_NYU_SHUKIN_CD(XML_rcd);
            row["NYU_SHUKIN_CNT"] = SUM_MONEY_DAT_field_NYU_SHUKIN_CNT(XML_rcd, i);
            row["NYU_SHUKIN_KIN"] = SUM_MONEY_DAT_field_NYU_SHUKIN_KIN(XML_rcd, i);
            row["CREATE_DATETIME"] = SUM_MONEY_DAT_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_MONEY_DAT_field_UPDATE_DATETIME(XML_rcd);
            row["KIKAN_FLG"] = SUM_MONEY_DAT_field_KIKAN_FLG(XML_rcd);
            SUM_MONEY_DAT_dt.Rows.Add(row);

            return SUM_MONEY_DAT_dt;
        }

        public static void do_insert_SUM_MONEY(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection connn = new SqlConnection(sqlcon);
            connn.Open();

            DataTable SUM_MONEY_DAT_dt = add_data_to_SUM_MONEY_DAT(XML_rcd, i);

            string sql_insert_MONEY = "INSERT INTO SUM_MONEY_DAT ( CONVERT_NO, LINE_NO, COMM_STATUS, STORE_KBN, STORE_CD, POS_NO, EIGYOU_DATE, SEISAN_NO, SEISAN_CNT, COMM_KBN, KAMOKU_CD, NYU_SHUKIN_CD, NYU_SHUKIN_CNT, NYU_SHUKIN_KIN, CREATE_DATETIME, UPDATE_DATETIME, KIKAN_FLG) VALUES ("
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["LINE_NO"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["STORE_CD"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["POS_NO"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["COMM_KBN"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["KAMOKU_CD"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["NYU_SHUKIN_CD"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["NYU_SHUKIN_CNT"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["NYU_SHUKIN_KIN"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_MONEY_DAT_dt.Rows[0]["KIKAN_FLG"].ToString() + "' "
                        + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert_MONEY, connn);
            cmd.ExecuteNonQuery();
            connn.Close();

            //Console.WriteLine(sql_insert);
            //Console.ReadLine();
        }
        public static string SUM_MONEY_DAT_field_CONVERT_NO(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_MONEY_DAT_field_LINE_NO(DataSet XML_rcd, int i)
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

        public static string SUM_MONEY_DAT_field_COMM_STATUS(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_MONEY_DAT_field_STORE_KBN(DataSet XML_rcd)
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

        public static string SUM_MONEY_DAT_field_STORE_CD(DataSet XML_rcd)
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

        public static string SUM_MONEY_DAT_field_POS_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                string posno = XML_rcd.Tables["H_H"].Rows[0]["iTH_PosNo"].ToString();
                ret = posno.PadLeft(2, '0');
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

        public static string SUM_MONEY_DAT_field_EIGYOU_DATE(DataSet XML_rcd)
        {
            string ret = "19000101";
            try
            {

                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_EigyoDate"].ToString();
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

        public static string SUM_MONEY_DAT_field_SEISAN_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_SeisanNo"].ToString();
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

        public static string SUM_MONEY_DAT_field_SEISAN_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString().Equals("0999")) ret = "1";

                else ret = "0";
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

        public static string SUM_MONEY_DAT_field_COMM_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double Mto_IhtNo = 0;
                        Mto_IhtNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (Mto_IhtNo >= 151 && Mto_IhtNo <= 160) ret = "1";

                        else if (Mto_IhtNo >= 161 && Mto_IhtNo <= 170) ret = "2";
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


        public static string SUM_MONEY_DAT_field_KAMOKU_CD(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        string Comm_kbn = SUM_MONEY_DAT_field_COMM_KBN(XML_rcd).ToString();

                        if (Comm_kbn == "1")
                        {
                            string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                            if (iHTNo == "151") ret = "01";
                            else if (iHTNo == "152") ret = "02";
                            else if (iHTNo == "153") ret = "03";
                            else if (iHTNo == "154") ret = "04";
                            else if (iHTNo == "155") ret = "05";
                            else if (iHTNo == "156") ret = "06";
                            else if (iHTNo == "157") ret = "07";
                            else if (iHTNo == "160") ret = "10";
                        }
                        else if (Comm_kbn == "2")
                        {
                            string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                            if (iHTNo == "151") ret = "01";
                            else if (iHTNo == "152") ret = "02";
                            else if (iHTNo == "153") ret = "03";
                            else if (iHTNo == "154") ret = "04";
                            else if (iHTNo == "155") ret = "05";
                            else if (iHTNo == "156") ret = "06";
                            else if (iHTNo == "157") ret = "07";
                            else if (iHTNo == "158") ret = "08";
                            else if (iHTNo == "159") ret = "09";
                            else if (iHTNo == "160") ret = "10";
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

        public static string SUM_MONEY_DAT_field_NYU_SHUKIN_CD(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        if (SUM_MONEY_DAT_field_COMM_KBN(XML_rcd).ToString() == "1")
                        {
                            string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                            if (iHTNo == "151") ret = "01";
                            else if (iHTNo == "152") ret = "02";
                            else if (iHTNo == "153") ret = "03";
                            else if (iHTNo == "154") ret = "04";
                            else if (iHTNo == "155") ret = "05";
                            else if (iHTNo == "156") ret = "06";
                            else if (iHTNo == "157") ret = "07";
                            else if (iHTNo == "160") ret = "99";
                        }
                        else if (SUM_MONEY_DAT_field_COMM_KBN(XML_rcd).ToString() == "2")
                        {
                            string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                            if (iHTNo == "151") ret = "01";
                            else if (iHTNo == "152") ret = "02";
                            else if (iHTNo == "153") ret = "04";
                            else if (iHTNo == "154") ret = "06";
                            else if (iHTNo == "155") ret = "07";
                            else if (iHTNo == "156") ret = "08";
                            else if (iHTNo == "157") ret = "09";
                            else if (iHTNo == "158") ret = "10";
                            else if (iHTNo == "159") ret = "12";
                            else if (iHTNo == "160") ret = "99";
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

        public static string SUM_MONEY_DAT_field_NYU_SHUKIN_CNT(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double str_HTSu = 0;
                        str_HTSu = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        ret = str_HTSu.ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 5 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 5);
                        }
                        else if (ret.Length > 5 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 4);
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

        public static string SUM_MONEY_DAT_field_NYU_SHUKIN_KIN(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        string str_lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                        ret = str_lHTKin;
                        ret = ret.Replace(",", "");
                        if (ret.Length > 9 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 9);
                        }
                        else if (ret.Length > 9 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 8);
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

        public static string SUM_MONEY_DAT_field_CREATE_DATETIME(DataSet XML_rcd)
        {
            string ret = "19000101 00:00:00";
            try
            {
                ret = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
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

        public static string SUM_MONEY_DAT_field_UPDATE_DATETIME(DataSet XML_rcd)
        {
            string ret = "19000101 00:00:00";
            try
            {
                ret = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");
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

        public static string SUM_MONEY_DAT_field_KIKAN_FLG(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
    }
}
