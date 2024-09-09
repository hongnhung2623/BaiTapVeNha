using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThuVienHinhTron;
namespace web_hinh_tron
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double r;

            if (double.TryParse(txtRadius.Text, out r))
            {
                if (r > 0)
                {
                    try
                    {
                        double area = TinhHinhTron.ChuVi(r);
                        double dt = TinhHinhTron.DienTich(r);

                        lblResult.Text = $"Diện tích hình tròn: {area:F2}<br/>Chu vi hình tròn: {dt:F2}";
                    }
                    catch (ArgumentException ex)
                    {
                        lblResult.Text = "Lỗi: " + ex.Message;
                    }
                }
                else
                {
                    lblResult.Text = "Bán kính phải lớn hơn 0.";
                }
            }
            else
            {
                lblResult.Text = "Giá trị nhập vào không hợp lệ. Vui lòng nhập một số thực.";
            }
        }
    }
}