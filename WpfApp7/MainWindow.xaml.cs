using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static void AddDeptInfo(DeptInfo m)
        {
            using (ORMContext db = new ORMContext())
            {
                var model = db.DeptInfos.Where(w => w.DeptName.Trim() == m.DeptName.Trim() && w.SubDept.Trim() == m.SubDept.Trim()).FirstOrDefault();
                if (model == null)
                {
                    db.DeptInfos.Add(m);
                    db.SaveChanges();
                    return;
                }
                model.SubDept = m.SubDept.Trim();
                model.DeptName = m.DeptName.Trim();
                model.DeptCode = m.DeptCode.Trim();
                model.RuleCode = m.RuleCode.Trim();
                db.SaveChanges();
            }
        }
        public static void AddUserInfo(EmployInfo u)
        {
            using (ORMContext db = new ORMContext())
            {
                var model = db.EmployInfos.Where(w => w.UserCode == u.UserCode).FirstOrDefault();
                if (model == null)
                {
                    db.EmployInfos.Add(u);
                    db.SaveChanges();
                    return;
                }
                model.UserCode = u.UserCode;
                model.Gender = u.Gender;
                model.EmployName = u.EmployName;
                model.RuleCode = u.RuleCode;
                db.SaveChanges();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddDeptInfo(new DeptInfo() { DeptCode = "1", DeptName="1", RuleCode = "1", SubDept = "1" });
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUserInfo(new EmployInfo() { UserCode = "2", DeptName = "2", EmployName = "2", Gender = "2",  RuleCode = 2, OrderCode = 2,NewCode = 3,NewCode2 = 3,NewCode3= 3 });
        }
    }
}
