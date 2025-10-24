using System.Data;
using System.Windows.Forms;

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