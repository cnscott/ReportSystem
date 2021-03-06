//using System;
//using System.Data;
//using System.Collections;
//
//using Webb.Data;
//using Webb.Collections;
//
//
//const int cOR                =  1;
//const int cAND               =  0;
//const int cEND               = -1;
//
//namespace Webb.Reports.DataProvider
//{
//	public class VictoryFilterHelper
//	{
//		static string CMD_SQL_Filter = "select * from Filters as a, FilterDetails as b where a.FilterID = b.FilterID and b.FilterID in (";
//
//		private static string GetFilterString(DataRow i_row)
//		{
//			int nOperator = Convert.ToInt32(i_row["Operator"]);
//
//			string nFieldName = i_row["FieldName"].ToString();
//
////			System.Type m_type = i_row.Table.Columns["FieldName"].DataType;
////			
////			string m_extfield = i_row["FieldName"].ToString();
////
////			if(WebbDataProvider.BuildInNumericFields.Contains(m_extfield))
////			{
////				if(m_type == typeof(System.String))
////				{
////					m_extfield = string.Format("VAL(IIF(ISNULL([{0}]),0,{0}))",i_row["FieldName"].ToString());
////				}
////			}
//
//			switch(nOperator)
//			{
//				case 0:   // numeric equal 
//					if ( atoi( playvalue ) == atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 1:  // numeric not equal
//					if ( atoi( playvalue ) != atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 2:  // numeric greater than
//					if ( atoi( playvalue ) > atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 3:  // numeric less than
//					if ( atoi( playvalue ) < atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 4:  // numeric greater than or equal
//					if ( atoi( playvalue ) >= atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 5:  // numeric less than or equal
//					if ( atoi( playvalue) <= atoi( filtervalue ) ) retVal = 1;
//					else retVal = 0;
//					break;
//
//					// String Operators
//				case 6:  // string equal
//					if ( stricmp( playvalue, filtervalue ) == 0 ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 7:  // string not equal
//					if ( stricmp( playvalue, filtervalue ) != 0 ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 8:  // string starts with
//					if ( strnicmp( playvalue, filtervalue, lstrlen( filtervalue ) ) == 0 )
//						retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 9:  // string ends with
//					strrev( filtervalue );  // reverse each string, then compare filtervalue
//					strrev( playvalue );    // to the beginning of playvalue
//
//					if (strnicmp( playvalue, filtervalue, lstrlen( filtervalue ) ) == 0 )
//						retVal = 1;
//					else retVal = 0;
//					break;
//
//				case 10:   //string includes
//					strupr( filtervalue );  // convert all lowercase letters in each string
//					strupr( playvalue );    // to uppercase so that the substring search is
//					// not case sensitive
//					if ( strstr( playvalue, filtervalue ) != NULL ) retVal = 1;
//					else retVal = 0;
//					break;
//
//				default:
//					retVal = 0;
//					break;	
//			}
//			return null;
//		}
//
//		private static string GetCutupFilter(int i_cutup,IDBManager i_manager)
//		{
//			DataTable m_TmpTable = new DataTable();	
//			string m_FiltersInfoStr = string.Format("{0})",i_cutup);
//			string m_SqlCmd1 = string.Format("{0}{1} order by [FieldName]",CMD_ACCESS_Filter,m_FiltersInfoStr);
//			string m_SqlCmd2 = string.Empty;
//			string m_TmpStr = string.Empty;
//			DataRow m_Row1 = null, m_Row2 = null;
//
//			i_manager.FillDataTable(m_TmpTable,m_SqlCmd1);
//
//			if(m_TmpTable.Rows.Count>0)
//			{
//				m_Row1 = m_TmpTable.Rows[0];			
//				m_TmpStr = string.Format("({0}",GetFilterString(m_Row1));
//
//				if(m_TmpTable.Rows.Count == 1)
//				{
//					m_SqlCmd2 = string.Format("{0})",m_TmpStr);
//				}
//
//				for(int i=1;i<m_TmpTable.Rows.Count;i++)
//				{
//					m_Row2 = m_TmpTable.Rows[i];
//					if(m_Row1["FieldName"].ToString()==m_Row2["FieldName"].ToString())
//					{
//						m_TmpStr += " or " + GetFilterString(m_Row2);
//						if(i==m_TmpTable.Rows.Count-1)
//						{
//							m_TmpStr += ")";
//							m_SqlCmd2 = m_SqlCmd2 + m_TmpStr;
//						}
//					}
//					else
//					{
//						m_Row1 = m_Row2;
//						m_TmpStr += ")";
//						if(i==m_TmpTable.Rows.Count-1)
//						{
//							m_SqlCmd2 += m_TmpStr;
//						}
//						else
//						{
//							m_SqlCmd2 += m_TmpStr + " and ";
//							m_TmpStr = "(" + GetFilterString(m_Row2);
//						}
//					}					
//				}
//			}
//			return m_SqlCmd2;
//		}
//
//		//Scott@2007-11-21 09:54 modified some of the following code.
//		public static string GetFiltersSQLCMD(Int32Collection i_cutups,IDBManager i_manager)
//		{
//			string m_result = String.Empty;
//
//			if(i_cutups!=null&&i_cutups.Count>0)
//			{
//				for (int i=0;i<i_cutups.Count;i++)
//				{
//					string m_tmp = VictoryFilterHelper.GetCutupFilter(i_cutups[i],i_manager);
//					
//					if(m_tmp==""||m_tmp==null)
//					{					
//						m_tmp = "true";
//					}
//					
//					m_result = string.Format("{0} {1} and ",m_result,m_tmp);	
//				}
//				
//				m_result = string.Format("{0} {1}",m_result,"true");
//			}
//			
//			return m_result;
//		}
//
//		//Scott@2007-11-21 13:07 modified some of the following code.
//		public static DBFilterCollection ConvertToDBFilter(Int32Collection i_FilterIDs, IDBManager i_DBManager)
//		{
//			DBFilterCollection m_DBFilters = new DBFilterCollection();
//
//			foreach(int i_FilterID in i_FilterIDs)
//			{
//				DBFilter m_DBFilter = ConvertToDBFilter(i_FilterID,i_DBManager);
//
//				m_DBFilters.Add(m_DBFilter);
//			}
//			return m_DBFilters;
//		}
//
//		public static DBFilter ConvertToDBFilter(int i_FilterID,IDBManager i_DBManager)
//		{
//			DataTable m_FilterTable = GetFilterInfoTable(i_FilterID, i_DBManager);
//
//			DBFilter m_DBFilter = new DBFilter();
//
//			foreach(DataRow i_Row in m_FilterTable.Rows)
//			{
//				string m_OP = i_Row["Lable"].ToString();
//
//				string m_Field = i_Row["FieldName"].ToString();
//
//				FilterTypes m_FilterType = FilterTypes.StrEqual;
//
//				object m_Value = i_Row["Value"];
//
//				FilterOperands m_FilterOperand = FilterOperands.And;
//
//				FilterCatalogs m_FilterCatalog = VictoryFilterHelper.GetCatalogFromFieldName(m_Field);
//
//				switch(m_OP)
//				{
//					case "Any Entry":	
//					{
//						continue;
//					}
//					case "No Entry":
//					{
//						return null;
//					}
//					case "Equal":
//					{
//						if(m_FilterCatalog == FilterCatalogs.Number)
//							m_FilterType = FilterTypes.NumEqual;
//						else
//							m_FilterType = FilterTypes.StrEqual;
//						break;
//					}
//					case "Greater Than":
//					{
//						m_FilterType = FilterTypes.NumGreater;
//						
//						break;
//					}
//					case "Less Than":
//					{
//						m_FilterType = FilterTypes.NumLess;
//					
//						break;
//					}
//					case "Starts With":
//					{
//						m_FilterType = FilterTypes.StrStartWith;
//						
//						break;
//					}
//					case "Ends With":
//					{
//						m_FilterType = FilterTypes.StrEndWith;
//
//						break;
//					}
//					case "Includes":
//					{
//						m_FilterType = FilterTypes.StrInclude;
//
//						break;
//					}
//					case "From To":			
//					{
//						m_FilterType = FilterTypes.NumLessOrEqual;
//
//						m_Value = i_Row["vMax"];
//						
//						//"From To" convert to two conditions
//						DBCondition m_DBConditionAdd = new DBCondition(m_Field,FilterTypes.NumGreaterOrEqual,i_Row["vMin"],m_FilterOperand);
//
//						m_DBFilter.Add(m_DBConditionAdd);
//
//						break;
//					}
//					case "Offense":
//					case "Defense":
//					case "Kick":
//					case "Practice":
//					case "1st Down":
//					case "2nd Down":
//					case "3rd Down":
//					case "4th Down":
//					case "Left":
//					case "Right":
//					case "Middle":
//					case "Run":
//					case "Pass":			
//					{
//						m_FilterType = FilterTypes.StrEqual;
//						
//						m_Value = m_OP;
//
//						break;
//					}
//					case "0":
//					case "1":
//					case "2":
//					case "3":
//					case "4":
//					case "5":
//					case "6":
//					case "7":
//					case "8":
//					case "9":
//					case "10":	
//					{
//						m_FilterType = FilterTypes.NumEqual;
//
//						m_Value = m_OP;
//
//						break;
//					}
//					default:
//						continue;
//				}
//				//switch end
//				DBCondition m_DBCondition = new DBCondition(m_Field,m_FilterType,m_Value,m_FilterOperand);
//
//				m_DBFilter.Add(m_DBCondition);
//			}
//
//			return m_DBFilter;
//		}
//
//		private static DataTable GetFilterInfoTable(int i_FilterID,IDBManager i_DBManager)
//		{
//			DataTable m_TmpTable = new DataTable("Filter");
//
//			string m_FilterCMD = string.Format("{0} {1}) order by [FieldName]",CMD_ACCESS_Filter,i_FilterID);
//			
//			i_DBManager.FillDataTable(m_TmpTable,m_FilterCMD);
//			
//			return m_TmpTable;
//		}
//
//		private static FilterCatalogs GetCatalogFromFieldName(string i_FieldName)
//		{
//			switch(i_FieldName)
//			{
//				case "PlayID":
//				case "GameID":
//				case "Angle":
//				{
//					return FilterCatalogs.Number;
//				}
//				default:
//				{
//					return FilterCatalogs.String;
//				}
//			}
//		}
//
//	}
//
//}
