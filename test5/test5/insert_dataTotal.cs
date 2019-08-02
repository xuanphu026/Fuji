using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace test5
{
    class insert_dataTotal
    {
        public static DataTable SUM_TOTAL_TRN_empty_table()
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
            dt.Columns.Add("BUSINESS_KBN");
            dt.Columns.Add("ACCOUNT_TIME");
            dt.Columns.Add("VISITOR_CD");
            dt.Columns.Add("SALES_CD");
            dt.Columns.Add("SALES_PRICE");
            dt.Columns.Add("DISCOUNT_PRICE");
            dt.Columns.Add("VISITOR1_NO");
            dt.Columns.Add("VISITOR2_NO");
            dt.Columns.Add("VISITOR3_NO");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("SYU_DATE");
            dt.Columns.Add("JIKAN_KBN");
            dt.Columns.Add("DISCOUNT_PRICE_JS");
            dt.Columns.Add("SALES_PRICE_TC");
            dt.Columns.Add("SALES_NUM");
            dt.Columns.Add("NEW_ORDER_TIME");
            dt.Columns.Add("ADD_ORDER_TIME");
            dt.Columns.Add("PROVIDE_TIME");
            dt.Columns.Add("KIKAN_FLG");
            return dt;

        }

        public static DataTable add_data_to_SUM_TOTAL_TRN(DataSet XML_rcd, int i)
        {
            DataTable SUM_TOTAL_TRN_dt = SUM_TOTAL_TRN_empty_table();

            DataRow row = SUM_TOTAL_TRN_dt.NewRow();
            row["CONVERT_NO"] = SUM_TOTAL_TRN_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_TOTAL_TRN_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_TOTAL_TRN_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_TOTAL_TRN_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_TOTAL_TRN_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_TOTAL_TRN_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_TOTAL_TRN_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_TOTAL_TRN_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_TOTAL_TRN_field_SEISAN_CNT(XML_rcd);
            row["RECEIPT_NO"] = SUM_TOTAL_TRN_field_RECEIPT_NO(XML_rcd);
            row["BUSINESS_KBN"] = SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd);
            row["ACCOUNT_TIME"] = SUM_TOTAL_TRN_field_ACCOUNT_TIME(XML_rcd);
            row["VISITOR_CD"] = SUM_TOTAL_TRN_field_VISITOR_CD(XML_rcd);
            row["SALES_CD"] = SUM_TOTAL_TRN_field_SALES_CD(XML_rcd);
            row["SALES_PRICE"] = SUM_TOTAL_TRN_field_SALES_PRICE(XML_rcd);
            row["DISCOUNT_PRICE"] = SUM_TOTAL_TRN_field_DISCOUNT_PRICE(XML_rcd, i);
            row["VISITOR1_NO"] = SUM_TOTAL_TRN_field_VISITOR1_NO(XML_rcd);
            row["VISITOR2_NO"] = SUM_TOTAL_TRN_field_VISITOR2_NO(XML_rcd);
            row["VISITOR3_NO"] = SUM_TOTAL_TRN_field_VISITOR3_NO(XML_rcd);
            row["CREATE_DATETIME"] = SUM_TOTAL_TRN_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_TOTAL_TRN_field_UPDATE_DATETIME(XML_rcd);
            row["SYU_DATE"] = SUM_TOTAL_TRN_field_SYU_DATE(XML_rcd);
            row["JIKAN_KBN"] = SUM_TOTAL_TRN_field_JIKAN_KBN(XML_rcd);
            row["DISCOUNT_PRICE_JS"] = SUM_TOTAL_TRN_field_DISCOUNT_PRICE_JS(XML_rcd, i);
            row["SALES_PRICE_TC"] = SUM_TOTAL_TRN_field_SALES_PRICE_TC(XML_rcd);
            row["SALES_NUM"] = SUM_TOTAL_TRN_field_SALES_NUM(XML_rcd);
            row["NEW_ORDER_TIME"] = SUM_TOTAL_TRN_field_NEW_ORDER_TIME(XML_rcd);
            row["ADD_ORDER_TIME"] = SUM_TOTAL_TRN_field_ADD_ORDER_TIME(XML_rcd);
            row["PROVIDE_TIME"] = SUM_TOTAL_TRN_field_PROVIDE_TIME(XML_rcd);
            row["KIKAN_FLG"] = SUM_TOTAL_TRN_field_KIKAN_FLG(XML_rcd);
            SUM_TOTAL_TRN_dt.Rows.Add(row);
            return SUM_TOTAL_TRN_dt;
        }

        public static void do_insert_SUM_TOTALTRN(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection coonn = new SqlConnection(sqlcon);
            coonn.Open();

            DataTable SUM_TOTAL_TRN_dt = add_data_to_SUM_TOTAL_TRN(XML_rcd, i);

            string sql_insert_TOTAL = "INSERT INTO SUM_TOTAL_TRN ( CONVERT_NO, LINE_NO, COMM_STATUS, STORE_KBN, STORE_CD, POS_NO, EIGYOU_DATE, SEISAN_NO, SEISAN_CNT, RECEIPT_NO, BUSINESS_KBN, ACCOUNT_TIME, VISITOR_CD, SALES_CD, SALES_PRICE, DISCOUNT_PRICE, VISITOR1_NO, VISITOR2_NO, VISITOR3_NO, CREATE_DATETIME, UPDATE_DATETIME, SYU_DATE, JIKAN_KBN, DISCOUNT_PRICE_JS, SALES_PRICE_TC, SALES_NUM, NEW_ORDER_TIME, ADD_ORDER_TIME, PROVIDE_TIME, KIKAN_FLG ) VALUES ("
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["LINE_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["STORE_CD"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["POS_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["RECEIPT_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["BUSINESS_KBN"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["ACCOUNT_TIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["VISITOR_CD"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SALES_CD"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SALES_PRICE"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["DISCOUNT_PRICE"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["VISITOR1_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["VISITOR2_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["VISITOR3_NO"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SYU_DATE"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["JIKAN_KBN"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["DISCOUNT_PRICE_JS"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SALES_PRICE_TC"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["SALES_NUM"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["NEW_ORDER_TIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["ADD_ORDER_TIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["PROVIDE_TIME"].ToString() + "', "
                         + "'" + SUM_TOTAL_TRN_dt.Rows[0]["KIKAN_FLG"].ToString() + "'"
                    + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert_TOTAL, coonn);
            cmd.ExecuteNonQuery();
            coonn.Close();

            //Console.WriteLine(sql_insert_TOTAL);
            //Console.ReadLine();
        }

        public static string SUM_TOTAL_TRN_field_CONVERT_NO(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_LINE_NO(DataSet XML_rcd, int i)
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

        public static string SUM_TOTAL_TRN_field_COMM_STATUS(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_STORE_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_STORE_CD(DataSet XML_rcd)
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

        public static string SUM_TOTAL_TRN_field_POS_NO(DataSet XML_rcd)
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

        public static string SUM_TOTAL_TRN_field_EIGYOU_DATE(DataSet XML_rcd)
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

        public static string SUM_TOTAL_TRN_field_SEISAN_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ///Xử lí logic
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

        public static string SUM_TOTAL_TRN_field_SEISAN_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
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

        public static string SUM_TOTAL_TRN_field_RECEIPT_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {

                ///Xử lí logic
                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrTuban"].ToString();
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

        public static string SUM_TOTAL_TRN_field_BUSINESS_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ///Xử lí logic
                string sTH_TrKBN = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString();
                string iTH_JushokuFlg = XML_rcd.Tables["H_H"].Rows[0]["iTH_JushokuFlg"].ToString();
                if (sTH_TrKBN.Equals("0000") || sTH_TrKBN.Equals("0002") && iTH_JushokuFlg.Equals("0")) ret = "00";
                else if (sTH_TrKBN.Equals("2000") || sTH_TrKBN.Equals("2002") && iTH_JushokuFlg.Equals("0")) ret = "30";
                else if (sTH_TrKBN.Equals("1000") && iTH_JushokuFlg.Equals("0")) ret = "32";
                else if (sTH_TrKBN.Equals("3000")) ret = "33";
                else if (sTH_TrKBN.Equals("0000") || sTH_TrKBN.Equals("0002") && iTH_JushokuFlg.Equals("1")) ret = "70";
                else if (sTH_TrKBN.Equals("2000") || sTH_TrKBN.Equals("1000") || sTH_TrKBN.Equals("2002") && iTH_JushokuFlg.Equals("1")) ret = "71";
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

        public static string SUM_TOTAL_TRN_field_ACCOUNT_TIME(DataSet XML_rcd)
        {
            string ret = "19000101000000";
            try
            {

                ///Xử lí logic
                string pos_time = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosTime"].ToString();
                string pos_date = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString();
                ret = pos_date + pos_time;
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

        public static string SUM_TOTAL_TRN_field_VISITOR_CD(DataSet XML_rcd)
        {
            string ret = " ";
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

        public static string SUM_TOTAL_TRN_field_SALES_CD(DataSet XML_rcd)
        {

            // dùng ith_tokutyuflg thay iTH_TokuChuFlg
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["H_H"].Rows[0]["ith_tokutyuflg"].ToString().Equals("0")) ret = "01";
                else if (XML_rcd.Tables["H_H"].Rows[0]["ith_tokutyuflg"].ToString().Equals("1")) ret = "02";
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

        public static string SUM_TOTAL_TRN_field_SALES_PRICE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    string Business = "0";

                    double s_lF_Gkei = 0;
                    double s_lF_ZeiGkei = 0;
                    double s_lF_HikazeiTaisyo = 0;
                    Business = SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd);
                    s_lF_Gkei = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[0]["lF_Gkei"].ToString());
                    s_lF_ZeiGkei = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[0]["lF_ZeiGkei"].ToString());
                    s_lF_HikazeiTaisyo = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[0]["lF_HikazeiTaisyo"].ToString());

                    ///Xử lí logic
                    if (Business != "30" || Business != "32" || Business != "71")
                    {
                        ret = Math.Floor(s_lF_Gkei - s_lF_ZeiGkei - s_lF_HikazeiTaisyo).ToString();
                    }
                    else if (Business == "30" || Business == "32" || Business == "71")
                    {
                        ret = Math.Floor((s_lF_Gkei - s_lF_ZeiGkei - s_lF_HikazeiTaisyo) * (-1)).ToString();
                    }

                    ret = ret.ToString().Replace(",", "");

                    if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                    {
                        ret = ret.Substring(ret.Length - 8);
                    }
                    else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                    {
                        ret = "-" + ret.Substring(ret.Length - 7);
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

        public static string SUM_TOTAL_TRN_field_DISCOUNT_PRICE(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                string no21_i = Program.SUM_ITEM_TRN_field_DISCOUNT2_PRICE(XML_rcd, i).ToString();
                string no21_item = Program.SUM_ITEM_TRN_field_DISCOUNT2_PRICE(XML_rcd, i).Substring(0,1).ToString();
                if ((no21_item == "0" || no21_item == "3") && no21_item != "-") ret = no21_i;
                else ret = (Convert.ToDouble(no21_i) * (-1)).ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 8);
                }
                else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 7);
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

        public static string SUM_TOTAL_TRN_field_VISITOR1_NO(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    double Nin = 0;
                    Nin = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[0]["iF_Ninzu"].ToString());
                    if (!SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(30) || !SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(32) || !SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(71)) ret = Math.Floor(Nin).ToString();
                    else if (SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(30) || SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(32) || SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(71)) ret = Math.Floor((Nin) * (-1)).ToString();
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

        public static string SUM_TOTAL_TRN_field_VISITOR2_NO(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_VISITOR3_NO(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_CREATE_DATETIME(DataSet XML_rcd)
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

        public static string SUM_TOTAL_TRN_field_UPDATE_DATETIME(DataSet XML_rcd)
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

        public static string SUM_TOTAL_TRN_field_SYU_DATE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (Convert.ToDouble(XML_rcd.Tables["H_H"].Rows[0]["sTH_PosTime"].ToString().Substring(0, 2)) < 6)
                {
                    ret = DateTime.ParseExact(XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString(), "yyyyMMdd",
                        CultureInfo.InvariantCulture).AddDays(-1).ToString("yyyyMMdd");
                }
                else
                {
                    ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString();
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

        public static string SUM_TOTAL_TRN_field_JIKAN_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosTime"].ToString().Substring(0, 2);
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

        public static string SUM_TOTAL_TRN_field_DISCOUNT_PRICE_JS(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals("70") || SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals("71"))
                {
                    ret = SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd);
                }
                else ret = "0";
                ret = ret.ToString().Replace(",", "");

                if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 8);
                }
                else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 7);
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

        public static string SUM_TOTAL_TRN_field_SALES_PRICE_TC(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (SUM_TOTAL_TRN_field_SALES_CD(XML_rcd).Equals("02")) ret = SUM_TOTAL_TRN_field_SALES_PRICE(XML_rcd).ToString();
                else ret = "0";


                ret = ret.Replace(",", "");

                if (ret.Length > 8 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 8);
                }
                else if (ret.Length > 8 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 7);
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

        public static string SUM_TOTAL_TRN_field_SALES_NUM(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    double s_iF_HikazeiTensu = 0;
                    s_iF_HikazeiTensu = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[0]["iF_HikazeiTensu"].ToString());

                    /////Xử lí logic
                    if (!SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(30) || !SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(32) || !SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(71))
                    {
                        ret = Math.Floor(s_iF_HikazeiTensu).ToString();
                    }
                    else if (SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(30) || SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(32) || SUM_TOTAL_TRN_field_BUSINESS_KBN(XML_rcd).Equals(71))
                    {
                        ret = Math.Floor((s_iF_HikazeiTensu) * (-1)).ToString();
                    }


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

        public static string SUM_TOTAL_TRN_field_NEW_ORDER_TIME(DataSet XML_rcd)
        {
            string ret = "";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_ADD_ORDER_TIME(DataSet XML_rcd)
        {
            string ret = "";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_PROVIDE_TIME(DataSet XML_rcd)
        {
            string ret = " ";
            return ret;
        }

        public static string SUM_TOTAL_TRN_field_KIKAN_FLG(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
    }
}
