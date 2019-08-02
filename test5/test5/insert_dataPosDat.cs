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
    class insert_dataPosDat
    {
        public static DataTable SUM_POS_DAT_empty_table()
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
            dt.Columns.Add("KYAKU_SU");
            dt.Columns.Add("GENKIN_CNT");
            dt.Columns.Add("GENKIN_KIN");
            dt.Columns.Add("MEAL_KEN_CNT");
            dt.Columns.Add("MEAL_KEN_KIN");
            dt.Columns.Add("BUY_YUTAI_CNT");
            dt.Columns.Add("BUY_YUTAI_KIN");
            dt.Columns.Add("STOCK_YUTAI_CNT");
            dt.Columns.Add("STOCK_YUTAI_KIN");
            dt.Columns.Add("KAKEURI_CNT");
            dt.Columns.Add("KAKE_KIN");
            dt.Columns.Add("JUN_URI_CNT");
            dt.Columns.Add("JUN_URI_TEN");
            dt.Columns.Add("JUN_URI_KIN");
            dt.Columns.Add("TAX");
            dt.Columns.Add("OUTTAX_URI_TEN");
            dt.Columns.Add("OUTTAX_URI_KIN");
            dt.Columns.Add("OUTTAX_KIN");
            dt.Columns.Add("INTAX_URI_TEN");
            dt.Columns.Add("INTAX_URI_KIN");
            dt.Columns.Add("INTAX_KIN");
            dt.Columns.Add("STOP_CNT");
            dt.Columns.Add("STOP_KIN");
            dt.Columns.Add("DISCNT_MEI_CNT");
            dt.Columns.Add("DISCNT_MEI_KIN");
            dt.Columns.Add("JYUSYOKU_CNT");
            dt.Columns.Add("JYUSYOKU_KIN");
            dt.Columns.Add("JYUSYOKU_DISCNT");
            dt.Columns.Add("TN_URI_KYAKU_CNT");
            dt.Columns.Add("TN_URI_KYAKU_TEN");
            dt.Columns.Add("TN_URI_KIN");
            dt.Columns.Add("BT_URI_DEAL_CNT");
            dt.Columns.Add("BT_URI_TEN");
            dt.Columns.Add("BT_URI_KIN");
            dt.Columns.Add("URI_GENKA");
            dt.Columns.Add("NYUKIN_TOTAL");
            dt.Columns.Add("SYUKIN_TOTAL");
            dt.Columns.Add("H_TSURI_KIN");
            dt.Columns.Add("Y_TSURI_KIN");
            dt.Columns.Add("GENKIN_ZANDAKA");
            dt.Columns.Add("MEAL_KEN_ZANDAKA");
            dt.Columns.Add("YUTAI_ZANDAKA");
            dt.Columns.Add("BUY_YUTAI_ZANDAKA");
            dt.Columns.Add("ONCE_CANCEL_CNT");
            dt.Columns.Add("ONCE_CANCEL_KIN");
            dt.Columns.Add("CANCEL_CNT");
            dt.Columns.Add("CANCEL_KIN");
            dt.Columns.Add("EXCHANGE_CNT");
            dt.Columns.Add("RENSYU_CNT");
            dt.Columns.Add("RENSYU_KIN");
            dt.Columns.Add("KAISYU_KIN");
            dt.Columns.Add("WEATHER_KBN");
            dt.Columns.Add("SHIIRE_KIN");
            dt.Columns.Add("ORDER_KIN");
            dt.Columns.Add("SEISAN_END_FLG");
            dt.Columns.Add("SEISAN_DATE");
            dt.Columns.Add("SEISAN_TIME");
            dt.Columns.Add("CREATE_DATETIME");
            dt.Columns.Add("UPDATE_DATETIME");
            dt.Columns.Add("SALES_GENKA");
            dt.Columns.Add("BANK_PAY_CD");
            dt.Columns.Add("KYAKU_SO1");
            dt.Columns.Add("KYAKU_SO2");
            dt.Columns.Add("KYAKU_SO3");
            dt.Columns.Add("KYAKU_SO4");
            dt.Columns.Add("KYAKU_SO5");
            dt.Columns.Add("KYAKU_M");
            dt.Columns.Add("KYAKU_W");
            dt.Columns.Add("SAELS_KIN_TO");
            dt.Columns.Add("SALES_SU_TO");
            dt.Columns.Add("SEISAN_KIN");
            dt.Columns.Add("SEISAN_GOSA");
            dt.Columns.Add("BANK_NYUKIN");
            dt.Columns.Add("SYO_ERR_CNT");
            dt.Columns.Add("URI_ERR_CNT");
            dt.Columns.Add("INSHI_REC_SU");
            dt.Columns.Add("INSHI_RYO_SU");
            dt.Columns.Add("WAON_CRD_KIN");
            dt.Columns.Add("WAON_CRD_KAI");
            dt.Columns.Add("WAON_CRD_MAI");
            dt.Columns.Add("WAON_PAY_KIN");
            dt.Columns.Add("WAON_PAY_KAI");
            dt.Columns.Add("WAON_HEN_KIN");
            dt.Columns.Add("WAON_HEN_KAI");
            dt.Columns.Add("WAON_CHG_KIN");
            dt.Columns.Add("WAON_CHG_KAI");
            dt.Columns.Add("WAON_CANCHG_KIN");
            dt.Columns.Add("WAON_CANCHG_KAI");
            dt.Columns.Add("Edy_PAY_KIN");
            dt.Columns.Add("Edy_PAY_KAI");
            dt.Columns.Add("Edy_HEN_KIN");
            dt.Columns.Add("Edy_HEN_KAI");
            dt.Columns.Add("Suica_PAY_KIN");
            dt.Columns.Add("Suica_PAY_KAI");
            dt.Columns.Add("Suica_HEN_KIN");
            dt.Columns.Add("Suica_HEN_KAI");
            dt.Columns.Add("ID_PAY_KIN");
            dt.Columns.Add("ID_PAY_KAI");
            dt.Columns.Add("ID_HEN_KIN");
            dt.Columns.Add("ID_HEN_KAI");
            dt.Columns.Add("QR_PAY_KIN");
            dt.Columns.Add("QR_PAY_KAI");
            dt.Columns.Add("QR_HEN_KIN");
            dt.Columns.Add("QR_HEN_KAI");
            dt.Columns.Add("PWAON_PAY_KIN");
            dt.Columns.Add("PWAON_PAY_KAI");
            dt.Columns.Add("PWAON_HEN_KIN");
            dt.Columns.Add("PWAON_HEN_KAI");
            dt.Columns.Add("CREDIT_PAY_KIN");
            dt.Columns.Add("CREDIT_PAY_KAI");
            dt.Columns.Add("CREDIT_HEN_KIN");
            dt.Columns.Add("CREDIT_HEN_KAI");
            dt.Columns.Add("QUICKPAY_PAY_KIN");
            dt.Columns.Add("QUICKPAY_PAY_KAI");
            dt.Columns.Add("QUICKPAY_HEN_KIN");
            dt.Columns.Add("QUICKPAY_HEN_KAI");
            dt.Columns.Add("NOMAL_TAX_URI_KIN");
            dt.Columns.Add("NOMAL_TAX_URI_KAI");
            dt.Columns.Add("NOMAL_INTAX_URI_KIN");
            dt.Columns.Add("NOMAL_INTAX_URI_KAI");
            dt.Columns.Add("NOMAL_OUTTAX_URI_KIN");
            dt.Columns.Add("NOMAL_OUTTAX_URI_KAI");
            dt.Columns.Add("REDUCED_TAX_URI_KIN");
            dt.Columns.Add("REDUCED_TAX_URI_KAI");
            dt.Columns.Add("REDUCED_INTAX_URI_KIN");
            dt.Columns.Add("REDUCED_INTAX_URI_KAI");
            dt.Columns.Add("REDUCED_OUTTAX_URI_KIN");
            dt.Columns.Add("REDUCED_OUTTAX_URI_KAI");
            dt.Columns.Add("NOMAL_TAX_KIN");
            dt.Columns.Add("NOMAL_INTAX_KIN");
            dt.Columns.Add("NOMAL_OUTTAX_KIN");
            dt.Columns.Add("REDUCED_TAX_KIN");
            dt.Columns.Add("REDUCED_INTAX_KIN");
            dt.Columns.Add("REDUCED_OUTTAX_KIN");
            dt.Columns.Add("KIKAN_FLG");

            return dt;
        }
        public static DataTable add_data_to_SUM_POS_DAT(DataSet XML_rcd, int i)
        {
            DataTable SUM_POS_DAT_dt = SUM_POS_DAT_empty_table();
            DataRow row = SUM_POS_DAT_dt.NewRow();
            row["CONVERT_NO"] = SUM_POS_DAT_field_CONVERT_NO(XML_rcd);
            row["LINE_NO"] = SUM_POS_DAT_field_LINE_NO(XML_rcd, i);
            row["COMM_STATUS"] = SUM_POS_DAT_field_COMM_STATUS(XML_rcd);
            row["STORE_KBN"] = SUM_POS_DAT_field_STORE_KBN(XML_rcd);
            row["STORE_CD"] = SUM_POS_DAT_field_STORE_CD(XML_rcd);
            row["POS_NO"] = SUM_POS_DAT_field_POS_NO(XML_rcd);
            row["EIGYOU_DATE"] = SUM_POS_DAT_field_EIGYOU_DATE(XML_rcd);
            row["SEISAN_NO"] = SUM_POS_DAT_field_SEISAN_NO(XML_rcd);
            row["SEISAN_CNT"] = SUM_POS_DAT_field_SEISAN_CNT(XML_rcd);
            row["KYAKU_SU"] = SUM_POS_DAT_field_KYAKU_SU(XML_rcd);
            row["GENKIN_CNT"] = SUM_POS_DAT_field_GENKIN_CNT(XML_rcd);
            row["GENKIN_KIN"] = SUM_POS_DAT_field_GENKIN_KIN(XML_rcd);
            row["MEAL_KEN_CNT"] = SUM_POS_DAT_field_MEAL_KEN_CNT(XML_rcd);
            row["MEAL_KEN_KIN"] = SUM_POS_DAT_field_MEAL_KEN_KIN(XML_rcd);
            row["BUY_YUTAI_CNT"] = SUM_POS_DAT_field_BUY_YUTAI_CNT(XML_rcd);
            row["BUY_YUTAI_KIN"] = SUM_POS_DAT_field_BUY_YUTAI_KIN(XML_rcd);
            row["STOCK_YUTAI_CNT"] = SUM_POS_DAT_field_STOCK_YUTAI_CNT(XML_rcd);
            row["STOCK_YUTAI_KIN"] = SUM_POS_DAT_field_STOCK_YUTAI_KIN(XML_rcd);
            row["KAKEURI_CNT"] = SUM_POS_DAT_field_KAKEURI_CNT(XML_rcd);
            row["KAKE_KIN"] = SUM_POS_DAT_field_KAKE_KIN(XML_rcd);
            row["JUN_URI_CNT"] = SUM_POS_DAT_field_JUN_URI_CNT(XML_rcd);
            row["JUN_URI_TEN"] = SUM_POS_DAT_field_JUN_URI_TEN(XML_rcd);
            row["JUN_URI_KIN"] = SUM_POS_DAT_field_JUN_URI_KIN(XML_rcd);
            row["TAX"] = SUM_POS_DAT_field_TAX(XML_rcd);
            row["OUTTAX_URI_TEN"] = SUM_POS_DAT_field_OUTTAX_URI_TEN(XML_rcd);
            row["OUTTAX_URI_KIN"] = SUM_POS_DAT_field_OUTTAX_URI_KIN(XML_rcd);
            row["OUTTAX_KIN"] = SUM_POS_DAT_field_OUTTAX_KIN(XML_rcd);
            row["INTAX_URI_TEN"] = SUM_POS_DAT_field_INTAX_URI_TEN(XML_rcd);
            row["INTAX_URI_KIN"] = SUM_POS_DAT_field_INTAX_URI_KIN(XML_rcd);
            row["INTAX_KIN"] = SUM_POS_DAT_field_INTAX_KIN(XML_rcd);
            row["STOP_CNT"] = SUM_POS_DAT_field_STOP_CNT(XML_rcd);
            row["STOP_KIN"] = SUM_POS_DAT_field_STOP_KIN(XML_rcd);
            row["DISCNT_MEI_CNT"] = SUM_POS_DAT_field_DISCNT_MEI_CNT(XML_rcd);
            row["DISCNT_MEI_KIN"] = SUM_POS_DAT_field_DISCNT_MEI_KIN(XML_rcd);
            row["JYUSYOKU_CNT"] = SUM_POS_DAT_field_JYUSYOKU_CNT(XML_rcd);
            row["JYUSYOKU_KIN"] = SUM_POS_DAT_field_JYUSYOKU_KIN(XML_rcd);
            row["JYUSYOKU_DISCNT"] = SUM_POS_DAT_field_JYUSYOKU_DISCNT(XML_rcd);
            row["TN_URI_KYAKU_CNT"] = SUM_POS_DAT_field_TN_URI_KYAKU_CNT(XML_rcd);
            row["TN_URI_KYAKU_TEN"] = SUM_POS_DAT_field_TN_URI_KYAKU_TEN(XML_rcd);
            row["TN_URI_KIN"] = SUM_POS_DAT_field_TN_URI_KIN(XML_rcd);
            row["BT_URI_DEAL_CNT"] = SUM_POS_DAT_field_BT_URI_DEAL_CNT(XML_rcd);
            row["BT_URI_TEN"] = SUM_POS_DAT_field_BT_URI_TEN(XML_rcd, i);
            row["BT_URI_KIN"] = SUM_POS_DAT_field_BT_URI_KIN(XML_rcd);
            row["URI_GENKA"] = SUM_POS_DAT_field_URI_GENKA(XML_rcd);
            row["NYUKIN_TOTAL"] = SUM_POS_DAT_field_NYUKIN_TOTAL(XML_rcd);
            row["SYUKIN_TOTAL"] = SUM_POS_DAT_field_SYUKIN_TOTAL(XML_rcd);
            row["H_TSURI_KIN"] = SUM_POS_DAT_field_H_TSURI_KIN(XML_rcd);
            row["Y_TSURI_KIN"] = SUM_POS_DAT_field_Y_TSURI_KIN(XML_rcd);
            row["GENKIN_ZANDAKA"] = SUM_POS_DAT_field_GENKIN_ZANDAKA(XML_rcd);
            row["MEAL_KEN_ZANDAKA"] = SUM_POS_DAT_field_MEAL_KEN_ZANDAKA(XML_rcd);
            row["YUTAI_ZANDAKA"] = SUM_POS_DAT_field_YUTAI_ZANDAKA(XML_rcd);
            row["BUY_YUTAI_ZANDAKA"] = SUM_POS_DAT_field_BUY_YUTAI_ZANDAKA(XML_rcd);
            row["ONCE_CANCEL_CNT"] = SUM_POS_DAT_field_ONCE_CANCEL_CNT(XML_rcd);
            row["ONCE_CANCEL_KIN"] = SUM_POS_DAT_field_ONCE_CANCEL_KIN(XML_rcd);
            row["CANCEL_CNT"] = SUM_POS_DAT_field_CANCEL_CNT(XML_rcd);
            row["CANCEL_KIN"] = SUM_POS_DAT_field_CANCEL_KIN(XML_rcd);
            row["EXCHANGE_CNT"] = SUM_POS_DAT_field_EXCHANGE_CNT(XML_rcd);
            row["RENSYU_CNT"] = SUM_POS_DAT_field_RENSYU_CNT(XML_rcd);
            row["RENSYU_KIN"] = SUM_POS_DAT_field_RENSYU_KIN(XML_rcd);
            row["KAISYU_KIN"] = SUM_POS_DAT_field_KAISYU_KIN(XML_rcd);
            row["WEATHER_KBN"] = SUM_POS_DAT_field_WEATHER_KBN(XML_rcd);
            row["SHIIRE_KIN"] = SUM_POS_DAT_field_SHIIRE_KIN(XML_rcd);
            row["ORDER_KIN"] = SUM_POS_DAT_field_ORDER_KIN(XML_rcd);
            row["SEISAN_END_FLG"] = SUM_POS_DAT_field_SEISAN_END_FLG(XML_rcd);
            row["SEISAN_DATE"] = SUM_POS_DAT_field_SEISAN_DATE(XML_rcd);
            row["SEISAN_TIME"] = SUM_POS_DAT_field_SEISAN_TIME(XML_rcd);
            row["CREATE_DATETIME"] = SUM_POS_DAT_field_CREATE_DATETIME(XML_rcd);
            row["UPDATE_DATETIME"] = SUM_POS_DAT_field_UPDATE_DATETIME(XML_rcd);
            row["SALES_GENKA"] = SUM_POS_DAT_field_SALES_GENKA(XML_rcd);
            row["BANK_PAY_CD"] = SUM_POS_DAT_field_BANK_PAY_CD(XML_rcd);
            row["KYAKU_SO1"] = SUM_POS_DAT_field_KYAKU_SO1(XML_rcd);
            row["KYAKU_SO2"] = SUM_POS_DAT_field_KYAKU_SO2(XML_rcd);
            row["KYAKU_SO3"] = SUM_POS_DAT_field_KYAKU_SO3(XML_rcd);
            row["KYAKU_SO4"] = SUM_POS_DAT_field_KYAKU_SO4(XML_rcd);
            row["KYAKU_SO5"] = SUM_POS_DAT_field_KYAKU_SO5(XML_rcd);
            row["KYAKU_M"] = SUM_POS_DAT_field_KYAKU_M(XML_rcd);
            row["KYAKU_W"] = SUM_POS_DAT_field_KYAKU_W(XML_rcd);
            row["SAELS_KIN_TO"] = SUM_POS_DAT_field_SAELS_KIN_TO(XML_rcd);
            row["SALES_SU_TO"] = SUM_POS_DAT_field_SALES_SU_TO(XML_rcd);
            row["SEISAN_KIN"] = SUM_POS_DAT_field_SEISAN_KIN(XML_rcd);
            row["SEISAN_GOSA"] = SUM_POS_DAT_field_SEISAN_GOSA(XML_rcd);
            row["BANK_NYUKIN"] = SUM_POS_DAT_field_BANK_NYUKIN(XML_rcd);
            row["SYO_ERR_CNT"] = SUM_POS_DAT_field_SYO_ERR_CNT(XML_rcd);
            row["URI_ERR_CNT"] = SUM_POS_DAT_field_URI_ERR_CNT(XML_rcd);
            row["INSHI_REC_SU"] = SUM_POS_DAT_field_INSHI_REC_SU(XML_rcd);
            row["INSHI_RYO_SU"] = SUM_POS_DAT_field_INSHI_RYO_SU(XML_rcd);
            row["WAON_CRD_KIN"] = SUM_POS_DAT_field_WAON_CRD_KIN(XML_rcd);
            row["WAON_CRD_KAI"] = SUM_POS_DAT_field_WAON_CRD_KAI(XML_rcd);
            row["WAON_CRD_MAI"] = SUM_POS_DAT_field_WAON_CRD_MAI(XML_rcd);
            row["WAON_PAY_KIN"] = SUM_POS_DAT_field_WAON_PAY_KIN(XML_rcd);
            row["WAON_PAY_KAI"] = SUM_POS_DAT_field_WAON_PAY_KAI(XML_rcd);
            row["WAON_HEN_KIN"] = SUM_POS_DAT_field_WAON_HEN_KIN(XML_rcd);
            row["WAON_HEN_KAI"] = SUM_POS_DAT_field_WAON_HEN_KAI(XML_rcd);
            row["WAON_CHG_KIN"] = SUM_POS_DAT_field_WAON_CHG_KIN(XML_rcd);
            row["WAON_CHG_KAI"] = SUM_POS_DAT_field_WAON_CHG_KAI(XML_rcd);
            row["WAON_CANCHG_KIN"] = SUM_POS_DAT_field_WAON_CANCHG_KIN(XML_rcd);
            row["WAON_CANCHG_KAI"] = SUM_POS_DAT_field_WAON_CANCHG_KAI(XML_rcd);
            row["Edy_PAY_KIN"] = SUM_POS_DAT_field_Edy_PAY_KIN(XML_rcd);
            row["Edy_PAY_KAI"] = SUM_POS_DAT_field_Edy_PAY_KAI(XML_rcd);
            row["Edy_HEN_KIN"] = SUM_POS_DAT_field_Edy_HEN_KIN(XML_rcd);
            row["Edy_HEN_KAI"] = SUM_POS_DAT_field_Edy_HEN_KAI(XML_rcd);
            row["Suica_PAY_KIN"] = SUM_POS_DAT_field_Suica_PAY_KIN(XML_rcd);
            row["Suica_PAY_KAI"] = SUM_POS_DAT_field_Suica_PAY_KAI(XML_rcd);
            row["Suica_HEN_KIN"] = SUM_POS_DAT_field_Suica_HEN_KIN(XML_rcd);
            row["Suica_HEN_KAI"] = SUM_POS_DAT_field_Suica_HEN_KAI(XML_rcd);
            row["ID_PAY_KIN"] = SUM_POS_DAT_field_ID_PAY_KIN(XML_rcd);
            row["ID_PAY_KAI"] = SUM_POS_DAT_field_ID_PAY_KAI(XML_rcd);
            row["ID_HEN_KIN"] = SUM_POS_DAT_field_ID_HEN_KIN(XML_rcd);
            row["ID_HEN_KAI"] = SUM_POS_DAT_field_ID_HEN_KAI(XML_rcd);
            row["QR_PAY_KIN"] = SUM_POS_DAT_field_QR_PAY_KIN(XML_rcd);
            row["QR_PAY_KAI"] = SUM_POS_DAT_field_QR_PAY_KAI(XML_rcd);
            row["QR_HEN_KIN"] = SUM_POS_DAT_field_QR_HEN_KIN(XML_rcd);
            row["QR_HEN_KAI"] = SUM_POS_DAT_field_QR_HEN_KAI(XML_rcd);
            row["PWAON_PAY_KIN"] = SUM_POS_DAT_field_PWAON_PAY_KIN(XML_rcd);
            row["PWAON_PAY_KAI"] = SUM_POS_DAT_field_PWAON_PAY_KAI(XML_rcd);
            row["PWAON_HEN_KIN"] = SUM_POS_DAT_field_PWAON_HEN_KIN(XML_rcd);
            row["PWAON_HEN_KAI"] = SUM_POS_DAT_field_PWAON_HEN_KAI(XML_rcd);
            row["CREDIT_PAY_KIN"] = SUM_POS_DAT_field_CREDIT_PAY_KIN(XML_rcd);
            row["CREDIT_PAY_KAI"] = SUM_POS_DAT_field_CREDIT_PAY_KAI(XML_rcd);
            row["CREDIT_HEN_KIN"] = SUM_POS_DAT_field_CREDIT_HEN_KIN(XML_rcd);
            row["CREDIT_HEN_KAI"] = SUM_POS_DAT_field_CREDIT_HEN_KAI(XML_rcd);
            row["QUICKPAY_PAY_KIN"] = SUM_POS_DAT_field_QUICKPAY_PAY_KIN(XML_rcd);
            row["QUICKPAY_PAY_KAI"] = SUM_POS_DAT_field_QUICKPAY_PAY_KAI(XML_rcd);
            row["QUICKPAY_HEN_KIN"] = SUM_POS_DAT_field_QUICKPAY_HEN_KIN(XML_rcd);
            row["QUICKPAY_HEN_KAI"] = SUM_POS_DAT_field_QUICKPAY_HEN_KAI(XML_rcd);
            row["NOMAL_TAX_URI_KIN"] = SUM_POS_DAT_field_NOMAL_TAX_URI_KIN(XML_rcd);
            row["NOMAL_TAX_URI_KAI"] = SUM_POS_DAT_field_NOMAL_TAX_URI_KAI(XML_rcd);
            row["NOMAL_INTAX_URI_KIN"] = SUM_POS_DAT_field_NOMAL_INTAX_URI_KIN(XML_rcd);
            row["NOMAL_INTAX_URI_KAI"] = SUM_POS_DAT_field_NOMAL_INTAX_URI_KAI(XML_rcd);
            row["NOMAL_OUTTAX_URI_KIN"] = SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KIN(XML_rcd);
            row["NOMAL_OUTTAX_URI_KAI"] = SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KAI(XML_rcd);
            row["REDUCED_TAX_URI_KIN"] = SUM_POS_DAT_field_REDUCED_TAX_URI_KIN(XML_rcd);
            row["REDUCED_TAX_URI_KAI"] = SUM_POS_DAT_field_REDUCED_TAX_URI_KAI(XML_rcd);
            row["REDUCED_INTAX_URI_KIN"] = SUM_POS_DAT_field_REDUCED_INTAX_URI_KIN(XML_rcd);
            row["REDUCED_INTAX_URI_KAI"] = SUM_POS_DAT_field_REDUCED_INTAX_URI_KAI(XML_rcd);
            row["REDUCED_OUTTAX_URI_KIN"] = SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KIN(XML_rcd);
            row["REDUCED_OUTTAX_URI_KAI"] = SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KAI(XML_rcd);
            row["NOMAL_TAX_KIN"] = SUM_POS_DAT_field_NOMAL_TAX_KIN(XML_rcd);
            row["NOMAL_INTAX_KIN"] = SUM_POS_DAT_field_NOMAL_INTAX_KIN(XML_rcd);
            row["NOMAL_OUTTAX_KIN"] = SUM_POS_DAT_field_NOMAL_OUTTAX_KIN(XML_rcd);
            row["REDUCED_TAX_KIN"] = SUM_POS_DAT_field_REDUCED_TAX_KIN(XML_rcd);
            row["REDUCED_INTAX_KIN"] = SUM_POS_DAT_field_REDUCED_INTAX_KIN(XML_rcd);
            row["REDUCED_OUTTAX_KIN"] = SUM_POS_DAT_field_REDUCED_OUTTAX_KIN(XML_rcd);
            row["KIKAN_FLG"] = SUM_POS_DAT_field_KIKAN_FLG(XML_rcd);
            SUM_POS_DAT_dt.Rows.Add(row);
            return SUM_POS_DAT_dt;
        }
        public static void do_insert_SUM_POSDAT(DataSet XML_rcd, int i)
        {
            string sqlcon = @"Data Source=NXPHU-DEV;Initial Catalog=org_db;Persist Security Info=True;User ID=sa;Password=sa@12345";
            SqlConnection coonn = new SqlConnection(sqlcon);
            coonn.Open();

            DataTable SUM_POS_DAT_dt = add_data_to_SUM_POS_DAT(XML_rcd, i);

            string sql_insert_POSDAT = "INSERT INTO SUM_POS_DAT (CONVERT_NO,LINE_NO,COMM_STATUS,STORE_KBN,STORE_CD,POS_NO,EIGYOU_DATE,SEISAN_NO,SEISAN_CNT,KYAKU_SU,GENKIN_CNT,GENKIN_KIN,MEAL_KEN_CNT,MEAL_KEN_KIN,BUY_YUTAI_CNT,BUY_YUTAI_KIN,STOCK_YUTAI_CNT,STOCK_YUTAI_KIN,KAKEURI_CNT,KAKE_KIN,JUN_URI_CNT,JUN_URI_TEN,JUN_URI_KIN,TAX,OUTTAX_URI_TEN,OUTTAX_URI_KIN,OUTTAX_KIN,INTAX_URI_TEN,INTAX_URI_KIN,INTAX_KIN,STOP_CNT,STOP_KIN,DISCNT_MEI_CNT,DISCNT_MEI_KIN,JYUSYOKU_CNT,JYUSYOKU_KIN,JYUSYOKU_DISCNT,TN_URI_KYAKU_CNT,TN_URI_KYAKU_TEN,TN_URI_KIN,BT_URI_DEAL_CNT,BT_URI_TEN,BT_URI_KIN,URI_GENKA,NYUKIN_TOTAL,SYUKIN_TOTAL,H_TSURI_KIN,Y_TSURI_KIN,GENKIN_ZANDAKA,MEAL_KEN_ZANDAKA,YUTAI_ZANDAKA,BUY_YUTAI_ZANDAKA,ONCE_CANCEL_CNT,ONCE_CANCEL_KIN,CANCEL_CNT,CANCEL_KIN,EXCHANGE_CNT,RENSYU_CNT,RENSYU_KIN,KAISYU_KIN,WEATHER_KBN,SHIIRE_KIN,ORDER_KIN,SEISAN_END_FLG,SEISAN_DATE,SEISAN_TIME,CREATE_DATETIME,UPDATE_DATETIME,SALES_GENKA,BANK_PAY_CD,KYAKU_SO1,KYAKU_SO2,KYAKU_SO3,KYAKU_SO4,KYAKU_SO5,KYAKU_M,KYAKU_W,SAELS_KIN_TO,SALES_SU_TO,SEISAN_KIN,SEISAN_GOSA,BANK_NYUKIN,SYO_ERR_CNT,URI_ERR_CNT,INSHI_REC_SU,INSHI_RYO_SU,WAON_CRD_KIN,WAON_CRD_KAI,WAON_CRD_MAI,WAON_PAY_KIN,WAON_PAY_KAI,WAON_HEN_KIN,WAON_HEN_KAI,WAON_CHG_KIN,WAON_CHG_KAI,WAON_CANCHG_KIN,WAON_CANCHG_KAI,EDY_PAY_KIN,EDY_PAY_KAI,EDY_HEN_KIN,EDY_HEN_KAI,SUICA_PAY_KIN,SUICA_PAY_KAI,SUICA_HEN_KIN,SUICA_HEN_KAI,ID_PAY_KIN,ID_PAY_KAI,ID_HEN_KIN,ID_HEN_KAI,QR_PAY_KIN,QR_PAY_KAI,QR_HEN_KIN,QR_HEN_KAI,PWAON_PAY_KIN,PWAON_PAY_KAI,PWAON_HEN_KIN,PWAON_HEN_KAI,CREDIT_PAY_KIN,CREDIT_PAY_KAI,CREDIT_HEN_KIN,CREDIT_HEN_KAI,QUICKPAY_PAY_KIN,QUICKPAY_PAY_KAI,QUICKPAY_HEN_KIN,QUICKPAY_HEN_KAI,NOMAL_TAX_URI_KIN,NOMAL_TAX_URI_KAI,NOMAL_INTAX_URI_KIN,NOMAL_INTAX_URI_KAI,NOMAL_OUTTAX_URI_KIN,NOMAL_OUTTAX_URI_KAI,REDUCED_TAX_URI_KIN,REDUCED_TAX_URI_KAI,REDUCED_INTAX_URI_KIN,REDUCED_INTAX_URI_KAI,REDUCED_OUTTAX_URI_KIN, REDUCED_OUTTAX_URI_KAI, NOMAL_TAX_KIN, NOMAL_INTAX_KIN, NOMAL_OUTTAX_KIN, REDUCED_TAX_KIN, REDUCED_INTAX_KIN, REDUCED_OUTTAX_KIN , KIKAN_FLG) VALUES ("
                + "'" + SUM_POS_DAT_dt.Rows[0]["CONVERT_NO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["LINE_NO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["COMM_STATUS"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STORE_KBN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STORE_CD"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["POS_NO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["EIGYOU_DATE"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_NO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SU"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["GENKIN_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["GENKIN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["MEAL_KEN_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["MEAL_KEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BUY_YUTAI_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BUY_YUTAI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STOCK_YUTAI_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STOCK_YUTAI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KAKEURI_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KAKE_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JUN_URI_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JUN_URI_TEN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JUN_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["TAX"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["OUTTAX_URI_TEN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["OUTTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["OUTTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["INTAX_URI_TEN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["INTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["INTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STOP_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["STOP_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["DISCNT_MEI_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["DISCNT_MEI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JYUSYOKU_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JYUSYOKU_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["JYUSYOKU_DISCNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["TN_URI_KYAKU_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["TN_URI_KYAKU_TEN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["TN_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BT_URI_DEAL_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BT_URI_TEN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BT_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["URI_GENKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NYUKIN_TOTAL"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SYUKIN_TOTAL"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["H_TSURI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Y_TSURI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["GENKIN_ZANDAKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["MEAL_KEN_ZANDAKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["YUTAI_ZANDAKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BUY_YUTAI_ZANDAKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ONCE_CANCEL_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ONCE_CANCEL_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CANCEL_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CANCEL_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["EXCHANGE_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["RENSYU_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["RENSYU_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KAISYU_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WEATHER_KBN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SHIIRE_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ORDER_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_END_FLG"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_DATE"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_TIME"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CREATE_DATETIME"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["UPDATE_DATETIME"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SALES_GENKA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BANK_PAY_CD"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SO1"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SO2"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SO3"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SO4"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_SO5"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_M"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KYAKU_W"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SAELS_KIN_TO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SALES_SU_TO"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SEISAN_GOSA"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["BANK_NYUKIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["SYO_ERR_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["URI_ERR_CNT"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["INSHI_REC_SU"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["INSHI_RYO_SU"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CRD_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CRD_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CRD_MAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CHG_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CHG_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CANCHG_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["WAON_CANCHG_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Edy_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Edy_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Edy_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Edy_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Suica_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Suica_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Suica_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["Suica_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ID_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ID_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ID_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["ID_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QR_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QR_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QR_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QR_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["PWAON_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["PWAON_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["PWAON_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["PWAON_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CREDIT_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CREDIT_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CREDIT_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["CREDIT_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QUICKPAY_PAY_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QUICKPAY_PAY_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QUICKPAY_HEN_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["QUICKPAY_HEN_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_TAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_TAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_INTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_INTAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_OUTTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_OUTTAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_TAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_TAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_INTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_INTAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_OUTTAX_URI_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_OUTTAX_URI_KAI"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_TAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_INTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["NOMAL_OUTTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_TAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_INTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["REDUCED_OUTTAX_KIN"].ToString() + "', "
                + "'" + SUM_POS_DAT_dt.Rows[0]["KIKAN_FLG"].ToString() + "'"
                + "); ";
            SqlCommand cmd = new SqlCommand(sql_insert_POSDAT, coonn);
            cmd.ExecuteNonQuery();
            coonn.Close();
        }
        public static string SUM_POS_DAT_field_CONVERT_NO(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_LINE_NO(DataSet XML_rcd, int i)
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
        public static string SUM_POS_DAT_field_COMM_STATUS(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_STORE_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_STORE_CD(DataSet XML_rcd)
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
                Console.WriteLine(("Source : " + CSE.Source));
                Console.WriteLine(("Message : " + CSE.Message));

                return ret;
            }
        }
        public static string SUM_POS_DAT_field_POS_NO(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_EIGYOU_DATE(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_SEISAN_NO(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_SEISAN_CNT(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_KYAKU_SU(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                        if (iHTNo == "140")
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_GENKIN_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                        if (iHTNo == "91")
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_GENKIN_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        string iHTNo = XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString();
                        if (iHTNo == "91")
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_MEAL_KEN_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if ((iHTNo >= 171 && iHTNo <= 175) || (iHTNo >= 181 && iHTNo <= 190) || (iHTNo >= 206 && iHTNo <= 210))
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_MEAL_KEN_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if ((iHTNo >= 171 && iHTNo <= 175) || (iHTNo >= 181 && iHTNo <= 190) || (iHTNo >= 206 && iHTNo <= 210))
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_BUY_YUTAI_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_BUY_YUTAI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_STOCK_YUTAI_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo >= 176 && iHTNo <= 180)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_STOCK_YUTAI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo >= 176 && iHTNo <= 180)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_KAKEURI_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo >= 176 && iHTNo <= 180)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_KAKE_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo >= 195 && iHTNo <= 205)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_JUN_URI_CNT(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_JUN_URI_TEN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double dHTSu_no2 = 0;
                    double dHTSu_no7 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 2)
                        {
                            dHTSu_no2 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        if (iHTNo == 7)
                        {
                            dHTSu_no7 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }

                        ret = (dHTSu_no2 - dHTSu_no7).ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_JUN_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double lHTKin_no2 = 0;
                    double lHTKin_no7 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 2)
                        {
                            lHTKin_no2 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 7)
                        {
                            lHTKin_no7 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        
                        ret = (lHTKin_no2 - lHTKin_no7).ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_TAX(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double lHTKin = 0;
                lHTKin = Convert.ToDouble(SUM_POS_DAT_field_OUTTAX_KIN(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_INTAX_KIN(XML_rcd).ToString());
                ret = lHTKin.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_OUTTAX_URI_TEN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 5)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_OUTTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 5)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_OUTTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 8)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_INTAX_URI_TEN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 6)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_INTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 6)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_INTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 9)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_STOP_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 76)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_STOP_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 76)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_DISCNT_MEI_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 51)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_DISCNT_MEI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 51)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_JYUSYOKU_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 84)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_JYUSYOKU_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_JYUSYOKU_DISCNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 84)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_TN_URI_KYAKU_CNT(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_TN_URI_KYAKU_TEN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_TN_URI_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_BT_URI_DEAL_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 140)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_BT_URI_TEN(DataSet XML_rcd, int i)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double dHTSu_no2 = 0;
                    double dHTSu_no7 = 0;
                    for (i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 2)
                        {
                            dHTSu_no2 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        if (iHTNo == 7)
                        {
                            dHTSu_no7 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }

                        ret = (dHTSu_no2 - dHTSu_no7).ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_BT_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double lHTKin_no2 = 0;
                    double lHTKin_no7 = 0;
                    double lHTKin_no51 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 2)
                        {
                            lHTKin_no2 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 7)
                        {
                            lHTKin_no7 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 51)
                        {
                            lHTKin_no51 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        ret = (lHTKin_no2 - lHTKin_no7 + lHTKin_no51).ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_URI_GENKA(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_NYUKIN_TOTAL(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 70)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_SYUKIN_TOTAL(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 71)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_H_TSURI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 398)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Y_TSURI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 399)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_GENKIN_ZANDAKA(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 131)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_MEAL_KEN_ZANDAKA(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_YUTAI_ZANDAKA(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_BUY_YUTAI_ZANDAKA(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_ONCE_CANCEL_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double dHTSu_no63 = 0;
                    double dHTSu_no352 = 0;
                    double dHTSu_no360 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 63)
                        {
                            dHTSu_no63 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        if (iHTNo == 352)
                        {
                            dHTSu_no352 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        if (iHTNo == 360)
                        {
                            dHTSu_no360 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        ret = (dHTSu_no63 + dHTSu_no352 + dHTSu_no360).ToString();

                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_ONCE_CANCEL_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double lHTKin_no63 = 0;
                    double lHTKin_no352 = 0;
                    double lHTKin_no360 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 63)
                        {
                            lHTKin_no63 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 352)
                        {
                            lHTKin_no352 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 360)
                        {
                            lHTKin_no360 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        ret = (lHTKin_no63 + lHTKin_no352 + lHTKin_no360).ToString();

                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_CANCEL_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 80)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_CANCEL_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 80)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_EXCHANGE_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double dHTSu_no72 = 0;
                    double dHTSu_no87 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 72)
                        {
                            dHTSu_no72 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        if (iHTNo == 87)
                        {
                            dHTSu_no87 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString());
                        }
                        
                        ret = (dHTSu_no72 + dHTSu_no87).ToString();

                        ret = ret.Replace(",", "");
                        if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 10);
                        }
                        else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_RENSYU_CNT(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_RENSYU_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KAISYU_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_WEATHER_KBN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = XML_rcd.Tables["H_H"].Rows[0]["iTH_Weather"].ToString();
                return ret;
            }
            catch(System.Exception CSE)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + " 取得エラー");
                Console.WriteLine("Source : " + CSE.Source);
                Console.WriteLine("Message : " + CSE.Message);
                return ret;
            }
        }
        public static string SUM_POS_DAT_field_SHIIRE_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_ORDER_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_SEISAN_END_FLG(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_SEISAN_DATE(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString();
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
        public static string SUM_POS_DAT_field_SEISAN_TIME(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                ret = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosTime"].ToString();
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
        public static string SUM_POS_DAT_field_CREATE_DATETIME(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_UPDATE_DATETIME(DataSet XML_rcd)
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
        public static string SUM_POS_DAT_field_SALES_GENKA(DataSet XML_rcd)
        {
            string ret = "0";
            return ret;
        }
        public static string SUM_POS_DAT_field_BANK_PAY_CD(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["H_H"] != null)
                {
                    string iTH_TantoNo = XML_rcd.Tables["H_H"].Rows[0]["iTH_TantoNo"].ToString();
                    if (iTH_TantoNo.Length < 8) iTH_TantoNo = iTH_TantoNo.PadLeft(8, '0');
                    ret = iTH_TantoNo;
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
        public static string SUM_POS_DAT_field_KYAKU_SO1(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KYAKU_SO2(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KYAKU_SO3(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KYAKU_SO4(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KYAKU_SO5(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_KYAKU_M(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 140)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_KYAKU_W(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_SAELS_KIN_TO(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_SALES_SU_TO(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_SEISAN_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                string sTH_PosDate = XML_rcd.Tables["H_H"].Rows[0]["sTH_PosDate"].ToString();
                ret = sTH_PosDate.Substring(sTH_PosDate.Length - 6, 6);
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
        public static string SUM_POS_DAT_field_SEISAN_GOSA(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    double lHTKin_no132 = 0;
                    double lHTKin_no134 = 0;
                    double lHTKin_no136 = 0;
                    double lHTKin_no138 = 0;
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 132)
                        {
                            lHTKin_no132 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 134)
                        {
                            lHTKin_no134 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 136)
                        {
                            lHTKin_no136 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        if (iHTNo == 138)
                        {
                            lHTKin_no138 = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString());
                        }
                        ret = (lHTKin_no132 + lHTKin_no134 + lHTKin_no136 + lHTKin_no138).ToString();
                        ret = ret.Replace(",", "");
                        if (ret.Length > 12 && ret.Substring(0, 1) != "-")
                        {
                            ret = ret.Substring(ret.Length - 12);
                        }
                        else if (ret.Length > 12 && ret.Substring(0, 1) == "-")
                        {
                            ret = "-" + ret.Substring(ret.Length - 11);
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
        public static string SUM_POS_DAT_field_BANK_NYUKIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 400)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 12 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 12);
                            }
                            else if (ret.Length > 12 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 11);
                            }
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
        public static string SUM_POS_DAT_field_SYO_ERR_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 85)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_URI_ERR_CNT(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 86)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_INSHI_REC_SU(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 108)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_INSHI_RYO_SU(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 108)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_CRD_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 7)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_CRD_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_WAON_CRD_MAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 7)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 211)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 211)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_WAON_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_WAON_CHG_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 383)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_CHG_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 383)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_CANCHG_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 384)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_WAON_CANCHG_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 384)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Edy_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 212)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Edy_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 212)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Edy_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_Edy_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_Suica_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 219)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Suica_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 219)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_Suica_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_Suica_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_ID_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 218)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_ID_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 218)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_ID_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_ID_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_QR_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 215)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_QR_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 215)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_QR_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_QR_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_PWAON_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 214)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_PWAON_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 214)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_PWAON_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_PWAON_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_CREDIT_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 192)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_CREDIT_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 192)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_CREDIT_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_CREDIT_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_QUICKPAY_PAY_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 217)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_QUICKPAY_PAY_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 217)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_QUICKPAY_HEN_KIN(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_QUICKPAY_HEN_KAI(DataSet XML_rcd) { string ret = "0"; return ret; }
        public static string SUM_POS_DAT_field_NOMAL_TAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double lHTKin = 0;
                lHTKin = Convert.ToDouble(SUM_POS_DAT_field_NOMAL_INTAX_URI_KIN(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KIN(XML_rcd).ToString());
                ret = lHTKin.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_NOMAL_TAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double dHTSu = 0;
                dHTSu = Convert.ToDouble(SUM_POS_DAT_field_NOMAL_INTAX_URI_KAI(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KAI(XML_rcd).ToString());
                ret = dHTSu.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_NOMAL_INTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 283)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_NOMAL_INTAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 283)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 284)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_NOMAL_OUTTAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 284)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_TAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double lHTKin = 0;
                lHTKin = Convert.ToDouble(SUM_POS_DAT_field_REDUCED_INTAX_URI_KIN(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KIN(XML_rcd).ToString());
                ret = lHTKin.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_REDUCED_TAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double dHTSu = 0;
                dHTSu = Convert.ToDouble(SUM_POS_DAT_field_REDUCED_INTAX_URI_KAI(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KAI(XML_rcd).ToString());
                ret = dHTSu.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_REDUCED_INTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 280)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_INTAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 280)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 281)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_OUTTAX_URI_KAI(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 281)
                        {
                            string dHTSu = XML_rcd.Tables["M_TO"].Rows[i]["dHTSu"].ToString();
                            ret = dHTSu;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_NOMAL_TAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double lHTKin = 0;
                lHTKin = Convert.ToDouble(SUM_POS_DAT_field_NOMAL_INTAX_KIN(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_NOMAL_OUTTAX_KIN(XML_rcd).ToString());
                ret = lHTKin.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_NOMAL_INTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 293)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_NOMAL_OUTTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 294)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_TAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                double lHTKin = 0;
                lHTKin = Convert.ToDouble(SUM_POS_DAT_field_REDUCED_INTAX_KIN(XML_rcd).ToString()) + Convert.ToDouble(SUM_POS_DAT_field_REDUCED_OUTTAX_KIN(XML_rcd).ToString());
                ret = lHTKin.ToString();
                ret = ret.Replace(",", "");
                if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                {
                    ret = ret.Substring(ret.Length - 10);
                }
                else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                {
                    ret = "-" + ret.Substring(ret.Length - 9);
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
        public static string SUM_POS_DAT_field_REDUCED_INTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 290)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_REDUCED_OUTTAX_KIN(DataSet XML_rcd)
        {
            string ret = "0";
            try
            {
                if (XML_rcd.Tables["M_TO"] != null)
                {
                    for (int i = 0; i < XML_rcd.Tables["M_TO"].Rows.Count; i++)
                    {
                        double iHTNo = Convert.ToDouble(XML_rcd.Tables["M_TO"].Rows[i]["iHTNo"].ToString());
                        if (iHTNo == 291)
                        {
                            string lHTKin = XML_rcd.Tables["M_TO"].Rows[i]["lHTKin"].ToString();
                            ret = lHTKin;
                            ret = ret.Replace(",", "");
                            if (ret.Length > 10 && ret.Substring(0, 1) != "-")
                            {
                                ret = ret.Substring(ret.Length - 10);
                            }
                            else if (ret.Length > 10 && ret.Substring(0, 1) == "-")
                            {
                                ret = "-" + ret.Substring(ret.Length - 9);
                            }
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
        public static string SUM_POS_DAT_field_KIKAN_FLG(DataSet XML_rcd) { string ret = "0"; return ret; }
    }
}
