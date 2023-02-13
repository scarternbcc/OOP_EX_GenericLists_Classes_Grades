namespace EXERCISE_GenericLists_Grades
{
    public partial class Form1 : Form
    {
        List<GradeInfo> grades = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void MakeEntry(int value, string grade)
        {
            GradeInfo gradeInfo = new()
            {
                maxPoints = value,
                letterGrade = grade
            };

            grades.Add(gradeInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeEntry(299, "F");
            MakeEntry(349, "D");
            MakeEntry(399, "C");
            MakeEntry(449, "B");
            MakeEntry(500, "A");
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            try
            {
                if(!int.TryParse(txtGrade.Text, out int grade) || grade < 0 || grade > 500)
                {
                    MessageBox.Show("Grade entered must be between 0 and 500.");
                    return;
                }

                //GradeInfo gi = grades.Where(g => g.maxPoints >= grade).FirstOrDefault();
                //GradeInfo gi = grades.FirstOrDefault(g => g.maxPoints >= grade);
                //MessageBox.Show("Grade: " + gi.letterGrade);

                // OR simply
                // there MAY be a slight performance increase by using .Where(predictate).FirstOrDefault()
                // but it would be minor
                // MessageBox.Show($"Grade: {grades.Where(g => g.maxPoints >= grade).FirstOrDefault().letterGrade}");
                MessageBox.Show($"Grade: {grades.FirstOrDefault(g => g.maxPoints >= grade).letterGrade}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}