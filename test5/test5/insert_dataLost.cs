using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Globalization;

namespace test5
{
    class insert_dataLost
    {
        public static DataTable SUM_LOST_DAT_empty_table()
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
            dt.Columns.Add("GOODS_CD");
            dt.Columns.Add("HAIKI_CNT");
            dt.Columns.Add("HAIKI_WEIGHT");
            dt.Columns.Add("HAIKI_KIN");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("HAIKI_DATETIME");
            dt.Columns.Add("JIKAN_KBN");
            dt.Columns.Add("HAIKI_KAI");
            dt.Columns.Add("SYU_DATE");
            dt.Columns.Add("HAKARI_KBN");
            dt.Columns.Add("HAIKI_CD");
            dt.Columns.Add("HAIKI_NAME");
            dt.Columns.Add("KIKAN_FLG");

            return dt;
        }
        public static DataTable add_data_to_SUM_LOST_DAT(DataSet XML_rcd, int i)
        {
            DataTable SUM_LOST_DAT_dt = SUM_LOST_DAT_empty_table();
            DataRow row = SUM_LOST_DAT_dt.NewRow();
            row["CONVERT_NO"] = SUM_LOST_DAT_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_LOST_DAT_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_LOST_DAT_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_LOST_DAT_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_LOST_DAT_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_LOST_DAT_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_LOST_DAT_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_LOST_DAT_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_LOST_DAT_field_SEISAN_CNT(XML_rcd);
            row["GOODS_CD"] = SUM_LOST_DAT_field_GOODS_CD(XML_rcd, i);
            row["HAIKI_CNT"] = SUM_LOST_DAT_field_HAIKI_CNT(XML_rcd, i);
            row["HAIKI_WEIGHT"] = SUM_LOST_DAT_field_HAIKI_WEIGHT(XML_rcd, i);
            row["HAIKI_KIN"] = SUM_LOST_DAT_field_HAIKI_KIN(XML_rcd);
            row["CREATE_DATETIME"] = SUM_LOST_DAT_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_LOST_DAT_field_UPDATE_DATETIME(XML_rcd);
            row["HAIKI_DATETIME"] = SUM_LOST_DAT_field_HAIKI_DATETIME(XML_rcd);
            row["JIKAN_KBN"] = SUM_LOST_DAT_field_JIKAN_KBN(XML_rcd);
            row["HAIKI_KAI"] = SUM_LOST_DAT_field_HAIKI_KAI(XML_rcd);
            row["SYU_DATE"] = SUM_LOST_DAT_field_SYU_DATE(XML_rcd);
            row["HAKARI_KBN"] = SUM_LOST_DAT_field_HAKARI_KBN(XML_rcd, i);
            row["HAIKI_CD"] = SUM_LOST_DAT_field_HAIKI_CD(XML_rcd);
            row["HAIKI_NAME"] = SUM_LOST_DAT_field_HAIKI_NAME(XML_rcd);
            row["KIKAN_FLG"] = SUM_LOST_DAT_field_KIKAN_FLG(XML_rcd);
            SUM_LOST_DAT_dt.Rows.Add(row);

            return SUM_LOST_DAT_dt;
        }
        public static void do_insert_SUM_LOSTDAT(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection connn = new SqlConnection(sqlcon);
            connn.Open();

            DataTable SUM_LOST_DAT_dt = add_data_to_SUM_LOST_DAT(XML_rcd, i);

            string sql_insert_LOST = "INSERT INTO SUM_LOST_DAT ( CONVERT_NO, LINE_NO, COMM_STATUS, STORE_KBN, STORE_CD, POS_NO, EIGYOU_DATE, SEISAN_NO, SEISAN_CNT, GOODS_CD, HAIKI_CNT, HAIKI_WEIGHT, HAIKI_KIN, CREATE_DATETIME, UPDATE_DATETIME, HAIKI_DATETIME, JIKAN_KBN, HAIKI_KAI, SYU_DATE, HAKARI_KBN, HAIKI_CD, HAIKI_NAME, KIKAN_FLG) VALUES ( "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["LINE_NO"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["STORE_CD"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["POS_NO"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["GOODS_CD"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_CNT"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_WEIGHT"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_KIN"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_DATETIME"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["JIKAN_KBN"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_KAI"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["SYU_DATE"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAKARI_KBN"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_CD"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["HAIKI_NAME"].ToString() + "', "
                             + "'" + SUM_LOST_DAT_dt.Rows[0]["KIKAN_FLG"].ToString() + "' "
                        + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert_LOST, connn);
            cmd.ExecuteNonQuery();
            connn.Close();

            

        }
        public static string SUM_LOST_DAT_field_CONVERT_NO(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_LOST_DAT_field_LINE_NO(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                ret = i.ToString();
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_COMM_STATUS(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_LOST_DAT_field_STORE_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_LOST_DAT_field_STORE_CD(DataSet XML_rcd)
        {
            string ret = "00000";
            try
            {
                string mcode = XML_rcd.Tables["H_H"].Rows[0]["iTH_MiseCode"].ToString();
                if (mcode.Length == 4 && (mcode[0].ToString().Equals("0") || mcode[0].ToString().Equals("1")))
                {
                    ret = "0" + mcode;
                }

                if (mcode.Length == 4 && (mcode[0].ToString().Equals("2") || mcode[0].ToString().Equals("3")))
                {
                    ret = mcode[0].ToString() + "0" + mcode[1].ToString() + mcode[2].ToString() + mcode[3].ToString();
                }
                if (mcode.Length == 4 && (Convert.ToInt32(mcode[0].ToString()) > 3))
                {
                    ret = mcode[0].ToString() + mcode[1].ToString() + "0" + mcode[2].ToString() + mcode[3].ToString();
                }

                if (mcode.Length < 4)
                {
                    ret = mcode.PadLeft(5, '0');
                }

                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_POS_NO(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_EIGYOU_DATE(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_SEISAN_NO(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_SEISAN_CNT(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }   
        public static string SUM_LOST_DAT_field_GOODS_CD(DataSet XML_rcd, int i)
        {
            string ret = "";
            try
            {
                if(XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        string sM_MstItemCode = XML_rcd.Tables["M_U"].Rows[i]["sM_MstItemCode"].ToString();
                        if (sM_MstItemCode.Length < 13)
                        {
                            ret = sM_MstItemCode.PadLeft(13, ' ');
                        }
                        else ret = sM_MstItemCode;
                    }
                    ret = ret.Substring(0, 13);
                }
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_CNT(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        string iM_KeiryoFlg = XML_rcd.Tables["M_U"].Rows[i]["iM_KeiryoFlg"].ToString();
                        double lM_RealWeight = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["lM_RealWeight"].ToString());
                        string iM_Suryo = XML_rcd.Tables["M_U"].Rows[i]["iM_Suryo"].ToString();

                        if (iM_KeiryoFlg == "0") ret = iM_Suryo;
                        else if (iM_KeiryoFlg == "1")
                        {
                            double equal = Math.Round(lM_RealWeight / 100, 3, MidpointRounding.AwayFromZero);
                            ret = equal.ToString();
                        }
                    }
                }
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_WEIGHT(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        string iM_KeiryoFlg = XML_rcd.Tables["M_U"].Rows[i]["iM_KeiryoFlg"].ToString();
                        string lM_RealWeight = XML_rcd.Tables["M_U"].Rows[i]["lM_RealWeight"].ToString();

                        if (iM_KeiryoFlg == "0") ret = "0";
                        else if (iM_KeiryoFlg == "1")
                        {
                            if (lM_RealWeight.Length < 2) lM_RealWeight = lM_RealWeight.PadLeft(2, ' ');
                            ret = lM_RealWeight.Substring(0, 2);
                        }
                    }
                }
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        double lM_Goka = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["lM_Goka"].ToString());
                        double iM_ZeiKbn = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["iM_ZeiKbn"].ToString());
                        double lM_Utizeigaku = Convert.ToDouble(XML_rcd.Tables["M_U"].Rows[i]["lM_Utizeigaku"].ToString());
                        if (iM_ZeiKbn == 0)
                        {
                            ret = (lM_Goka - lM_Utizeigaku).ToString();
                        }
                        else if (iM_ZeiKbn == 1) ret = lM_Goka.ToString();
                    }
                }
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_CREATE_DATETIME(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_UPDATE_DATETIME(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_DATETIME(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                string sTH_PosDate = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString();
                string sTH_PosTime = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosTime"].ToString();
                ret = (sTH_PosDate.Substring(0, 8) + sTH_PosTime.Substring(0, 4)).ToString();
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_JIKAN_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_SYU_DATE(DataSet XML_rcd)
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
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAKARI_KBN(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_U"] != null)
                {
                    for (i = 0; i <= XML_rcd.Tables["M_U"].Rows.Count; i++)
                    {
                        ret = XML_rcd.Tables["M_U"].Rows[0]["iM_KeiryoFlg"].ToString();
                    }
                }
                return ret;
            }
            catch (System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_LOST_DAT_field_HAIKI_CD(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }
        public static string SUM_LOST_DAT_field_HAIKI_NAME(DataSet XML_rcd)
        {
            string ret = "NULL";
            return ret;
        }
        public static string SUM_LOST_DAT_field_KIKAN_FLG(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
    }
}
