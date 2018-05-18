using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOL;
using BLL;

public partial class Admin_Workshop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GetWorkShops();
    }

    private void GetWorkShops()
    {
        WorkshopBusiness WB = new WorkshopBusiness();
        List<tbl_Workshop> Ls = WB.GetWorkshops();
        GridView1.DataSource = Ls;
        GridView1.DataBind();
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        tbl_Workshop Wp = new tbl_Workshop();
        Wp.WorkShopTitle = txtWorkShopTitle.Text;
        Wp.WorkShopDate =DateTime.Parse(txtWorkShopDate.Text);
        Wp.WorkShopTopics = txtWorkShopTopics.Text;
        Wp.WorkShopDuration = txtWorkShopDuration.Text;
        WorkshopBusiness WB = new WorkshopBusiness();
        WB.InsertWorkshop(Wp);
        GetWorkShops();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(GridView1.SelectedValue.ToString());
        WorkshopBusiness WB = new WorkshopBusiness();
        tbl_Workshop Wp= WB.GetWorkshopById(id);
        txtWorkShopTitle.Text = Wp.WorkShopTitle;
        txtWorkShopDate.Text = Wp.WorkShopDate.ToString();
        txtWorkShopDuration.Text = Wp.WorkShopDuration;
        txtWorkShopTopics.Text = Wp.WorkShopTopics;
    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        tbl_Workshop Wp = new tbl_Workshop();
        Wp.WorkShopTitle = txtWorkShopTitle.Text;
        Wp.WorkShopDate = DateTime.Parse(txtWorkShopDate.Text);
        Wp.WorkShopTopics = txtWorkShopTopics.Text;
        Wp.WorkShopDuration = txtWorkShopDuration.Text;

        WorkshopBusiness WB = new WorkshopBusiness();
        int id = int.Parse(GridView1.SelectedValue.ToString());
        WB.UpdateWorkshopById(Wp, id);

        GetWorkShops();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

        WorkshopBusiness WB = new WorkshopBusiness();
        int id = int.Parse(GridView1.SelectedValue.ToString());
        WB.DeleteWorkshopById(id);
        GetWorkShops();
    }
}