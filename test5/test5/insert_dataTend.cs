using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test5
{
    class insert_dataTend
    {
        public static DataTable SUM_TEND_TRN_empty_table()
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
            dt.Columns.Add("MEDIA_KBN");
            dt.Columns.Add("MEDIA_NAME");
            dt.Columns.Add("PROC1_KBN");
            dt.Columns.Add("PROC2_KBN");
            dt.Columns.Add("DETAIL_KBN");
            dt.Columns.Add("TICKET_CD");
            dt.Columns.Add("TICKET_NAME");
            dt.Columns.Add("PUB_STORE_CD");
            dt.Columns.Add("DISC_KBN");
            dt.Columns.Add("DP_CD");
            dt.Columns.Add("MENU_CD");
            dt.Columns.Add("PLU_CD");
            dt.Columns.Add("DISC_STATUS");
            dt.Columns.Add("DISC_AMOUNT");
            dt.Columns.Add("TANKA");
            dt.Columns.Add("MAISU");
            dt.Columns.Add("ZAN_MAISU");
            dt.Columns.Add("DEP0_AMOUNT");
            dt.Columns.Add("PAY_AMOUNT");
            dt.Columns.Add("DIFF_AMOUNT");
            dt.Columns.Add("DIFF_KBN");
            dt.Columns.Add("ENT_CD");
            dt.Columns.Add("EXP_DATE");
            dt.Columns.Add("MEDIA_TAX");
            dt.Columns.Add("WAON_RWCOM1");
            dt.Columns.Add("WAON_RWCOM2");
            dt.Columns.Add("WAON_POS_PT");
            dt.Columns.Add("WAON_SPRWID");
            dt.Columns.Add("WAON_KBN");
            dt.Columns.Add("WAON_VOID_NO");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("KIKAN_FLG");

            return dt;

        }

        public static DataTable add_data_to_SUM_TEND_TRN(DataSet XML_rcd, int i)
        {
            DataTable SUM_TEND_TRN_dt = SUM_TEND_TRN_empty_table();

            DataRow row = SUM_TEND_TRN_dt.NewRow();
            row["CONVERT_NO"] = SUM_TEND_TRN_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_TEND_TRN_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_TEND_TRN_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_TEND_TRN_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_TEND_TRN_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_TEND_TRN_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_TEND_TRN_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_TEND_TRN_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_TEND_TRN_field_SEISAN_CNT(XML_rcd);
            row["RECEIPT_NO"] = SUM_TEND_TRN_field_RECEIPT_NO(XML_rcd);
            row["MEDIA_KBN"] = SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i);
            row["MEDIA_NAME"] = SUM_TEND_TRN_field_MEDIA_NAME(XML_rcd, i);
            row["PROC1_KBN"] = SUM_TEND_TRN_field_PROC1_KBN(XML_rcd);
            row["PROC2_KBN"] = SUM_TEND_TRN_field_PROC2_KBN(XML_rcd);
            row["DETAIL_KBN"] = SUM_TEND_TRN_field_DETAIL_KBN(XML_rcd);
            row["TICKET_CD"] = SUM_TEND_TRN_field_TICKET_CD(XML_rcd, i);
            row["TICKET_NAME"] = SUM_TEND_TRN_field_TICKET_NAME(XML_rcd, i);
            row["PUB_STORE_CD"] = SUM_TEND_TRN_field_PUB_STORE_CD(XML_rcd);
            row["DISC_KBN"] = SUM_TEND_TRN_field_DISC_KBN(XML_rcd);
            row["DP_CD"] = SUM_TEND_TRN_field_DP_CD(XML_rcd);
            row["MENU_CD"] = SUM_TEND_TRN_field_MENU_CD(XML_rcd);
            row["PLU_CD"] = SUM_TEND_TRN_field_PLU_CD(XML_rcd);
            row["DISC_STATUS"] = SUM_TEND_TRN_field_DISC_STATUS(XML_rcd);
            row["DISC_AMOUNT"] = SUM_TEND_TRN_field_DISC_AMOUNT(XML_rcd);
            row["TANKA"] = SUM_TEND_TRN_field_TANKA(XML_rcd);
            row["MAISU"] = SUM_TEND_TRN_field_MAISU(XML_rcd, i);
            row["ZAN_MAISU"] = SUM_TEND_TRN_field_ZAN_MAISU(XML_rcd);
            row["DEP0_AMOUNT"] = SUM_TEND_TRN_field_DEP0_AMOUNT(XML_rcd);
            row["PAY_AMOUNT"] = SUM_TEND_TRN_field_PAY_AMOUNT(XML_rcd, i);
            row["DIFF_AMOUNT"] = SUM_TEND_TRN_field_DIFF_AMOUNT(XML_rcd);
            row["DIFF_KBN"] = SUM_TEND_TRN_field_DIFF_KBN(XML_rcd);
            row["ENT_CD"] = SUM_TEND_TRN_field_ENT_CD(XML_rcd);
            row["EXP_DATE"] = SUM_TEND_TRN_field_EXP_DATE(XML_rcd);
            row["MEDIA_TAX"] = SUM_TEND_TRN_field_MEDIA_TAX(XML_rcd);
            row["WAON_RWCOM1"] = SUM_TEND_TRN_field_WAON_RWCOM1(XML_rcd);
            row["WAON_RWCOM2"] = SUM_TEND_TRN_field_WAON_RWCOM2(XML_rcd);
            row["WAON_POS_PT"] = SUM_TEND_TRN_field_WAON_POS_PT(XML_rcd);
            row["WAON_SPRWID"] = SUM_TEND_TRN_field_WAON_SPRWID(XML_rcd, i);
            row["WAON_KBN"] = SUM_TEND_TRN_field_WAON_KBN(XML_rcd, i);
            row["WAON_VOID_NO"] = SUM_TEND_TRN_field_WAON_VOID_NO(XML_rcd);
            row["CREATE_DATETIME"] = SUM_TEND_TRN_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_TEND_TRN_field_UPDATE_DATETIME(XML_rcd);
            row["KIKAN_FLG"] = SUM_TEND_TRN_field_KIKAN_FLG(XML_rcd);
            SUM_TEND_TRN_dt.Rows.Add(row);

            return SUM_TEND_TRN_dt;
        }

        public static void do_insert_SUM_TENDTRN(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection coonn = new SqlConnection(sqlcon);
            coonn.Open();

            DataTable SUM_TEND_TRN_dt = add_data_to_SUM_TEND_TRN(XML_rcd, i);

            string sql_insert_TENDTRN = "INSERT INTO SUM_TEND_TRN (CONVERT_NO,	LINE_NO, COMM_STATUS,	STORE_KBN,	STORE_CD,	POS_NO,	EIGYOU_DATE,	SEISAN_NO,	SEISAN_CNT,	RECEIPT_NO,	MEDIA_KBN,	MEDIA_NAME,	PROC1_KBN,	PROC2_KBN,	DETAIL_KBN,	TICKET_CD,	TICKET_NAME,	PUB_STORE_CD,	DISC_KBN,	DP_CD,	MENU_CD,	PLU_CD,  DISC_STATUS,	DISC_AMOUNT,	TANKA,	MAISU,	ZAN_MAISU,	DEP0_AMOUNT,	PAY_AMOUNT,	DIFF_AMOUNT,	DIFF_KBN,	ENT_CD,	EXP_DATE,	MEDIA_TAX,	WAON_RWCOM1,	WAON_RWCOM2,	WAON_POS_PT,	WAON_SPRWID,	WAON_KBN,	WAON_VOID_NO,	CREATE_DATETIME, UPDATE_DATETIME,	KIKAN_FLG) VALUES ("
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["LINE_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["STORE_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["POS_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["RECEIPT_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["MEDIA_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["MEDIA_NAME"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["PROC1_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["PROC2_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DETAIL_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["TICKET_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["TICKET_NAME"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["PUB_STORE_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DISC_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DP_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["MENU_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["PLU_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DISC_STATUS"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DISC_AMOUNT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["TANKA"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["MAISU"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["ZAN_MAISU"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DEP0_AMOUNT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["PAY_AMOUNT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DIFF_AMOUNT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["DIFF_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["ENT_CD"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["EXP_DATE"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["MEDIA_TAX"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_RWCOM1"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_RWCOM2"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_POS_PT"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_SPRWID"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_KBN"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["WAON_VOID_NO"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                         + "'" + SUM_TEND_TRN_dt.Rows[0]["KIKAN_FLG"].ToString() + "'"
                    + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert_TENDTRN, coonn);
            cmd.ExecuteNonQuery();
            coonn.Close();
        }

        public static string SUM_TEND_TRN_field_CONVERT_NO(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_LINE_NO(DataSet XML_rcd, int i)
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
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }

        public static string SUM_TEND_TRN_field_COMM_STATUS(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_STORE_KBN(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_STORE_CD(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_POS_NO(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_EIGYOU_DATE(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_SEISAN_NO(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_SEISAN_CNT(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_RECEIPT_NO(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
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

        public static string SUM_TEND_TRN_field_MEDIA_KBN(DataSet XML_rcd, int i)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null && XML_rcd.Tables["M_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        string lF_GenkinHarai = "0";
                        lF_GenkinHarai = XML_rcd.Tables["F_F"].Rows[i]["lF_GenkinHarai"].ToString();

                        int iFr_Code = 0;
                        iFr_Code = Convert.ToInt32(XML_rcd.Tables["M_F"].Rows[i]["iFr_Code"].ToString());

                        int iF_SNbkSyubetsu = 0;
                        int iF_SWbkSyubetsu = 0;
                        iF_SNbkSyubetsu = Convert.ToInt32(XML_rcd.Tables["F_F"].Rows[i]["iF_SNbkSyubetsu"].ToString());
                        iF_SWbkSyubetsu = Convert.ToInt32(XML_rcd.Tables["F_F"].Rows[i]["iF_SWbkSyubetsu"].ToString());

                        if (lF_GenkinHarai != "0") ret = "01";
                        if (iF_SWbkSyubetsu == 0 || iF_SNbkSyubetsu == 0)
                        {
                            if (iFr_Code >= 1 && iFr_Code <= 30)
                            {
                                ret = "12";
                            }
                        }
                        if (iFr_Code >= 22 && iFr_Code <= 25) ret = "02";
                        else if (iFr_Code == 26 || iFr_Code == 27 || iFr_Code == 29 || iFr_Code == 30) ret = "03";
                        else if (iFr_Code >= 42 && iFr_Code <= 44 || iFr_Code == 47 || iFr_Code == 48 || iFr_Code == 50) ret = "04";
                        else if (iFr_Code == 28 || iFr_Code == 49) ret = "07";
                        else if (iFr_Code == 41) ret = "08";
                        else if (iFr_Code >= 32 && iFr_Code <= 35) ret = "13";
                        else if (iFr_Code == 31) ret = "14";
                        else ret = "11";
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

        public static string SUM_TEND_TRN_field_MEDIA_NAME(DataSet XML_rcd, int i)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    for (i = 0; i <= XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("01")) ret = "現金";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("02")) ret = "クレジット";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("03")) ret = "掛け";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("04")) ret = "その他決済";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("07")) ret = "交通系IC支払";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("08")) ret = "ＷＡＯＮ支払";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("12")) ret = "値引・割引券支払";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("13")) ret = "QR支払";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("14")) ret = "WAONPOINT支払";
                        else if (SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).Equals("11")) ret = "金券支払";

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

        public static string SUM_TEND_TRN_field_PROC1_KBN(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
                string sTH_TrKbn = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString();
                string equal = sTH_TrKbn.Substring(0, 1);
                if (equal == "0" || equal == "3") ret = "1";
                else ret = "2";
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

        public static string SUM_TEND_TRN_field_PROC2_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                string sTH_TrKbn = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString();
                string equal = sTH_TrKbn.Substring(0, 1);
                if (equal == "0" || equal == "3") ret = "1";
                else ret = "2";
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

        public static string SUM_TEND_TRN_field_DETAIL_KBN(DataSet XML_rcd)
        {

            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_TICKET_CD(DataSet XML_rcd, int i)
        {

            string ret = "";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        string media_kbn = SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString();
                        if (media_kbn != "11" || media_kbn != "12") ret = "0";
                        else
                        {
                            double equal = 0;
                            double Media = 0;
                            Media = Convert.ToDouble(SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString());
                            double Name = 0;
                            Name = Convert.ToDouble(SUM_TEND_TRN_field_MEDIA_NAME(XML_rcd, i).ToString());
                            equal = Media - Name;
                            ret = equal.ToString();
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

        public static string SUM_TEND_TRN_field_TICKET_NAME(DataSet XML_rcd, int i)
        {

            string ret = "";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        string media_kbn = SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString();
                        if (media_kbn != "11" || media_kbn != "12") ret = "null";
                        else
                        {
                            double equal = 0;
                            double Media_kbn = 0;
                            double Name_kbn = 0;

                            Media_kbn = Convert.ToDouble(SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString());

                            Name_kbn = Convert.ToDouble(SUM_TEND_TRN_field_MEDIA_NAME(XML_rcd, i).ToString());

                            equal = Media_kbn - Name_kbn;
                            ret = equal.ToString();
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

        public static string SUM_TEND_TRN_field_PUB_STORE_CD(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_DISC_KBN(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_DP_CD(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_MENU_CD(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_PLU_CD(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_DISC_STATUS(DataSet XML_rcd)
        {
            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_DISC_AMOUNT(DataSet XML_rcd)
        {
            string ret = null;
            try
            {
                ret = Convert.ToInt32(ret).ToString();
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

        public static string SUM_TEND_TRN_field_TANKA(DataSet XML_rcd)
        {

            string ret = null;
            ret = Convert.ToInt32(ret).ToString();
            return ret;
        }

        public static string SUM_TEND_TRN_field_MAISU(DataSet XML_rcd, int i)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["M_F"].Rows.Count; i++)
                    {
                        string iFr_Maisu = "0";
                        string media = "0";

                        media = SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString();
                        iFr_Maisu = XML_rcd.Tables["M_F"].Rows[i]["iFr_Maisu"].ToString();


                        if (media == "12") ret = "1";
                        else if (media == "11") ret = iFr_Maisu;
                        else ret = "0";
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

        public static string SUM_TEND_TRN_field_ZAN_MAISU(DataSet XML_rcd)
        {

            string ret = null;
            try
            {
                ret = Convert.ToInt32(ret).ToString();
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

        public static string SUM_TEND_TRN_field_DEP0_AMOUNT(DataSet XML_rcd)
        {

            string ret = null;
            try
            {
                ret = Convert.ToInt32(ret).ToString();
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

        public static string SUM_TEND_TRN_field_PAY_AMOUNT(DataSet XML_rcd, int i)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_F"] != null && XML_rcd.Tables["M_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        double media_kbn = 0;
                        media_kbn = Convert.ToDouble(SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString());
                        double lF_GenkinHarai = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[i]["lF_GenkinHarai"].ToString());
                        double lFr_Goka = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[i]["lFr_Goka"].ToString());
                        double lFr_KenKankin = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[i]["lFr_KenKankin"].ToString());
                        double lFr_KenYojo = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[i]["lFr_KenYojo"].ToString());
                        double lF_SWbkGkei = Convert.ToDouble(XML_rcd.Tables["F_F"].Rows[i]["lF_SWbkGkei"].ToString());
                        double M_Fsum = 0;

                        if (media_kbn == 01)
                        {
                            ret = lF_GenkinHarai.ToString();
                        }

                        else if (media_kbn != 01 || media_kbn != 12)
                        {
                            M_Fsum = (lFr_Goka - (lFr_KenKankin + lFr_KenYojo));
                            ret = M_Fsum.ToString();
                        }
                        else if (media_kbn == 12) ret = lF_SWbkGkei.ToString();
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

        public static string SUM_TEND_TRN_field_DIFF_AMOUNT(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_F"] != null)
                {
                    double lFr_KenKankin = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[0]["lFr_KenKankin"].ToString());
                    double lFr_KenYojo = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[0]["lFr_KenYojo"].ToString());
                    double equa = 0;
                    equa = lFr_KenKankin + lFr_KenYojo;
                    ret = equa.ToString();
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

        public static string SUM_TEND_TRN_field_DIFF_KBN(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_F"] != null)
                {
                    double lFr_KenKankin = 0;
                    double lFr_KenYojo = 0;
                    lFr_KenKankin = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[0]["lFr_KenKankin"].ToString());
                    lFr_KenYojo = Convert.ToDouble(XML_rcd.Tables["M_F"].Rows[0]["lFr_KenYojo"].ToString());

                    if (lFr_KenKankin > 0) ret = "1";
                    else if (lFr_KenYojo > 0) ret = "2";
                    else ret = "0";
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

        public static string SUM_TEND_TRN_field_ENT_CD(DataSet XML_rcd)
        {

            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_EXP_DATE(DataSet XML_rcd)
        {

            string ret = null;
            return ret;
        }

        public static string SUM_TEND_TRN_field_MEDIA_TAX(DataSet XML_rcd)
        {

            string ret = null;
            try
            {
                ret = Convert.ToInt32(ret).ToString();
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

        public static string SUM_TEND_TRN_field_WAON_RWCOM1(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_WAON_RWCOM2(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_WAON_POS_PT(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }

        public static string SUM_TEND_TRN_field_WAON_SPRWID(DataSet XML_rcd, int i)
        {

            string ret = "NULL";
            try
            {
                if (XML_rcd.Tables["F_F"] != null)
                {
                    for (i = 0; i < XML_rcd.Tables["F_F"].Rows.Count; i++)
                    {
                        string media_kbn = SUM_TEND_TRN_field_MEDIA_KBN(XML_rcd, i).ToString();
                        if (media_kbn == "08")
                        {
                            if (XML_rcd.Tables["F_CR"] != null)
                            {
                                string sCr_TermIdentId = XML_rcd.Tables["F_CR"].Rows[i]["sCr_TermIdentId"].ToString();
                                if (sCr_TermIdentId.Length < 13) sCr_TermIdentId = sCr_TermIdentId.PadLeft(13, ' ');
                                ret = sCr_TermIdentId.Substring(0, 13);
                            }
                        }

                        else ret = "NULL";
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

        public static string SUM_TEND_TRN_field_WAON_KBN(DataSet XML_rcd, int i)
        {

            string ret = "0";
            try
            {
                if (XML_rcd.Tables["F_CR"] != null)
                {
                    string sTH_TrKbn = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString();
                    string iCr_CreSyubetu = XML_rcd.Tables["F_CR"].Rows[0]["iCr_CreSyubetu"].ToString();

                    if ((sTH_TrKbn == "0000" && iCr_CreSyubetu == "7") || (sTH_TrKbn == "0002" && iCr_CreSyubetu == "7")) ret = "01";
                    else if ((sTH_TrKbn == "2000" && iCr_CreSyubetu == "7") || (sTH_TrKbn == "2002" && iCr_CreSyubetu == "7")) ret = "11";
                    else if (sTH_TrKbn == "0071") ret = "21";
                    else if (sTH_TrKbn == "2071") ret = "31";
                    else ret = " ";
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

        public static string SUM_TEND_TRN_field_WAON_VOID_NO(DataSet XML_rcd)
        {

            string ret = "0";
            try
            {
                string sTH_TrKbn = XML_rcd.Tables["H_H"].Rows[0]["sTH_TrKbn"].ToString();
                string sTH_MotoTuban = XML_rcd.Tables["H_H"].Rows[0]["sTH_MotoTuban"].ToString();

                if (sTH_TrKbn == "2071") ret = sTH_MotoTuban;
                else ret = "";
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

        public static string SUM_TEND_TRN_field_CREATE_DATETIME(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_UPDATE_DATETIME(DataSet XML_rcd)
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

        public static string SUM_TEND_TRN_field_KIKAN_FLG(DataSet XML_rcd)
        {

            string ret = "0";
            return ret;
        }
    }
}
