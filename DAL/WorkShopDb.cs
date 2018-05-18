using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
  public  class WorkShopDb
    {
      public bool InsertWorkshop(tbl_Workshop Wp)
      {
          try
          {
              string conStr = "Data Source=rakib;Initial Catalog=WorkShopDB;Integrated Security=True";
              string cmdStr = "insert into tbl_WorkShop values(@WorkShopTitle,@WorkShopDate,@WorkShopDuration,@WorkshopTopics,null,null,null,null) ";
              SqlConnection con = new SqlConnection(conStr);
              SqlCommand cmd = new SqlCommand(cmdStr, con);
              cmd.Parameters.AddWithValue("@WorkShopTitle", Wp.WorkShopTitle);
              cmd.Parameters.AddWithValue("@WorkShopDate", Wp.WorkShopDate);
              cmd.Parameters.AddWithValue("@WorkShopDuration", Wp.WorkShopDuration);
              cmd.Parameters.AddWithValue("@WorkshopTopics", Wp.WorkShopTopics);
              con.Open();
              cmd.ExecuteNonQuery();
              con.Close();
              return true;
          }
          catch
          {
              return false;
          }
      }

       public List<tbl_Workshop> GetWorkshops()
      {
              List<tbl_Workshop> Ls;
              Ls = new List<tbl_Workshop>();

              string conStr = "Data Source=rakib;Initial Catalog=WorkShopDB;Integrated Security=True";
              string cmdStr = "select * from tbl_WorkShop";
              SqlConnection con = new SqlConnection(conStr);
              SqlCommand cmd = new SqlCommand(cmdStr, con);
              con.Open();
             SqlDataReader dr =  cmd.ExecuteReader();
             while (dr.Read())
             {
                 tbl_Workshop Wp = new tbl_Workshop();
                 Wp.WorkShopId =int.Parse( dr["WorkShopId"].ToString());
                 Wp.WorkShopTitle = dr["WorkShopTitle"].ToString();
                 Wp.WorkShopDate = DateTime.Parse(dr["WorkShopDate"].ToString());
                 Wp.WorkShopDuration = dr["WorkShopDuration"].ToString();
                 Wp.WorkShopTopics = dr["WorkShopTopics"].ToString();

                 Ls.Add(Wp);
             }
             dr.Close();
              con.Close();
              return Ls;

      }

       public tbl_Workshop GetWorkshopById(int WorkShopId)
       {
           tbl_Workshop Wp=null;

           string conStr = "Data Source=rakib;Initial Catalog=WorkShopDB;Integrated Security=True";
           string cmdStr = "select * from tbl_WorkShop where WorkShopId=@WorkShopId";
           SqlConnection con = new SqlConnection(conStr);
           SqlCommand cmd = new SqlCommand(cmdStr, con);
           cmd.Parameters.AddWithValue("@WorkShopId", WorkShopId);
           con.Open();
           SqlDataReader dr = cmd.ExecuteReader();
          if (dr.Read())
           {
               Wp = new tbl_Workshop();
               Wp.WorkShopId = int.Parse(dr["WorkShopId"].ToString());
               Wp.WorkShopTitle = dr["WorkShopTitle"].ToString();
               Wp.WorkShopDate = DateTime.Parse(dr["WorkShopDate"].ToString());
               Wp.WorkShopDuration = dr["WorkShopDuration"].ToString();
               Wp.WorkShopTopics = dr["WorkShopTopics"].ToString();
           }
           dr.Close();
           con.Close();
           return Wp;

       }

       public bool UpdateWorkshopById(tbl_Workshop Wp, int WorkShopId)
       {
           try
           {
               string conStr = "Data Source=rakib;Initial Catalog=WorkShopDB;Integrated Security=True";
               string cmdStr =@"Update tbl_WorkShop 
                                                Set WorkShopTitle=@WorkShopTitle,WorkShopDate=@WorkShopDate,
                                                WorkShopDuration=@WorkShopDuration,WorkshopTopics=@WorkshopTopics 
                                                where  WorkShopId=@WorkShopId";
               SqlConnection con = new SqlConnection(conStr);
               SqlCommand cmd = new SqlCommand(cmdStr, con);
               cmd.Parameters.AddWithValue("@WorkShopTitle", Wp.WorkShopTitle);
               cmd.Parameters.AddWithValue("@WorkShopDate", Wp.WorkShopDate);
               cmd.Parameters.AddWithValue("@WorkShopDuration", Wp.WorkShopDuration);
               cmd.Parameters.AddWithValue("@WorkshopTopics", Wp.WorkShopTopics);
               cmd.Parameters.AddWithValue("@WorkShopId",WorkShopId);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               return true;
           }
           catch
           {
               return false;
           }
       }
       
      public bool DeleteWorkshopById(int WorkShopId)
       {
           try
           {
               string conStr = "Data Source=rakib;Initial Catalog=WorkShopDB;Integrated Security=True";
               string cmdStr = @"Delete from tbl_WorkShop where  WorkShopId=@WorkShopId";
               SqlConnection con = new SqlConnection(conStr);
               SqlCommand cmd = new SqlCommand(cmdStr, con);
               cmd.Parameters.AddWithValue("@WorkShopId", WorkShopId);
               con.Open();
               cmd.ExecuteNonQuery();
               con.Close();
               return true;
           }
           catch
           {
               return false;
           }
       }
    }
}
