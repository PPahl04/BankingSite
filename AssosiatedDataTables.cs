using System.Windows.Forms;
using System.Data;

namespace BankingSite
{
	public partial class AssotiatedDataTables : Form
	{
		public AssotiatedDataTables(DataTable data)
		{
			InitializeComponent();

			dgvAssosiatedDataTable.DataSource = data;
			dgvAssosiatedDataTable.Refresh();
		}
	}
}