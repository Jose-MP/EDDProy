using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Ordenamiento;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pilas mPilas = new Pilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colas mColas = new Colas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void circularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LDobles mDo = new LDobles();
            mDo.MdiParent = this;
            mDo.Show();

        }

        private void simplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSimples mSim = new LSimples();
            mSim.MdiParent = this;
            mSim.Show();
        }

        private void doblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LCirculares mCircu = new LCirculares();
            mCircu.MdiParent = this;
            mCircu.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exponente mEx = new Exponente();
            mEx.MdiParent = this;
            mEx.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factorial mFac = new Factorial();
            mFac.MdiParent = this;
            mFac.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Busqueda mBus = new Busqueda();
            mBus.MdiParent = this;
            mBus.Show();
        }

        private void secuenciaFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fibonacci mFi = new Fibonacci();
            mFi.MdiParent = this;
            mFi.Show();
        }

        private void algoritmoHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hanoi mHan = new Hanoi();
            mHan.MdiParent = this;
            mHan.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suma mSum = new Suma();
            mSum.MdiParent = this;
            mSum.Show();
        }

        private void mezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Burbuja mBur = new Burbuja();
            mBur.MdiParent = this;
            mBur.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSort mQS = new QuickSort();
            mQS.MdiParent = this;
            mQS.Show();
        }

        private void seToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellSort mSS = new ShellSort();
            mSS.MdiParent = this;
            mSS.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Radix mRa = new Radix();
            mRa.MdiParent = this;
            mRa.Show();
        }

        private void intercalaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mezclaDirectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void secuencialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Binaria mBi = new Binaria();
            mBi.MdiParent = this;
            mBi.Show();
        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hash mHa = new Hash();
            mHa.MdiParent = this;
            mHa.Show();
        }

        private void metodosDeOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
