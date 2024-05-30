using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoCaro
{
    public partial class fGameBoard : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        SoundPlayer player = new SoundPlayer(@"E:\Program\ProjectVisual\CoCaro\CoCaro\Properties\NIKKE-April-Fools-Soundtrack-BGM-OST.wav");
        private bool isPlaying = false;
        public fGameBoard()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            caroChess.KhoiTaoMangOCo();
            grs = pnlBanCo.CreateGraphics();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tmchuChay_Tick(object sender, EventArgs e)
        {
            lblChuoiChu.Location = new Point(lblChuoiChu.Location.X, lblChuoiChu.Location.Y - 1);
            if (lblChuoiChu.Location.Y + lblChuoiChu.Height < 0)
            {
                lblChuoiChu.Location = new Point(lblChuoiChu.Location.X, pnlChuChay.Height);
            }
        }

        private void fGameBoard_Load(object sender, EventArgs e)
        {
            lblChuoiChu.Text = "- Hai bên lần lượt đánh\n vào từng ô.\n- Bên nào đạt 5 con\n trên 1 hàng ngang,\n hàng dọc, chéo xuôi,\n chéo ngược mà không\n bị chặn 2 đầu là người\n chiến thắng. \n- Nếu bàn cờ đầy thì\n hòa cờ .\n * LƯU Ý : Trong chế độ\n PVC Computer luôn là\n người chơi 1 \n*CHÚC BẠN CHƠI \nGAME VUI VẺ";
            tmChuChay.Enabled = true;
        }

        private void pnlBanCo_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnlBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
                return;
            if (caroChess.DanhCo(e.X, e.Y, grs))
            {
                if (caroChess.KiemTraChienThang())
                    caroChess.KetThucTroChoi();
                else
                {
                    if (caroChess.CheDoChoi == 2)
                    {
                        caroChess.KhoiDongComputer(grs);
                        if (caroChess.KiemTraChienThang())
                            caroChess.KetThucTroChoi();
                    }
                }
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        private void btnPlayervsCom_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayerVsCom(grs);
        }

        private void btnPlayervsPlayer_Click(object sender, EventArgs e)
        {
            grs.Clear(pnlBanCo.BackColor);
            caroChess.StartPlayerVsPlayer(grs);
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            if (!isPlaying)
            {
                player.Play();
                isPlaying = true;
            }
            else
            {
                player.Stop();
                isPlaying= false;
            }
        }
    }
}
