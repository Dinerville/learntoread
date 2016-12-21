using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Media;

namespace Learn2Read
{
    public partial class SoundTable : System.Web.UI.Page
    {
        Button btn2Video;
        Button btnWords;
        Button btnExercise;
        Button btnArticle;

        protected void Page_Load(object sender, EventArgs e)
        {
            btn2Video = new Button();
            btn2Video.Text = "Видео урок";
            btn2Video.Attributes.Add("runat", "server");
            btn2Video.Click += new EventHandler(btn2Video_Click);

            btnExercise = new Button();
            btnExercise.Text = "Упражнения";
            btnExercise.Attributes.Add("runat", "server");
            btnExercise.Click += new EventHandler(btnExercise_Click);

            btnArticle = new Button();
            btnArticle.Text = "Статья о произношении";
            btnArticle.Attributes.Add("runat", "server");
            btnArticle.Click += new EventHandler(btnArticle_Click);

            Menu.Controls.Add(new LiteralControl("<div id=\"DivVideoLesson\">"));
            Menu.Controls.Add(btn2Video);
            Menu.Controls.Add(new LiteralControl("</div>"));
            Menu.Controls.Add(new LiteralControl("<div id=\"DivExercise\">"));
            Menu.Controls.Add(btnExercise);
            Menu.Controls.Add(new LiteralControl("</div>"));
            Menu.Controls.Add(new LiteralControl("<div id=\"DivArticle\">"));
            Menu.Controls.Add(btnArticle);
            Menu.Controls.Add(new LiteralControl("</div>"));
            Menu.Controls.Add(new LiteralControl("<br />"));
            Menu.Controls.Add(new LiteralControl("<br />"));
            Menu.Controls.Add(new LiteralControl("<br />"));
        }

        //sounds
        //vovels short
        protected void I_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetIModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetIModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetIModel().VideoLink));
        }

        protected void U_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetUModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetUModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetUModel().VideoLink));
        }

        protected void A_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetAModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetAModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetAModel().VideoLink));
        }

        protected void Arev_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetArevModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetArevModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetArevModel().VideoLink));
        }

        protected void Erev_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetErevModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetErevModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetErevModel().VideoLink));
        }

        protected void E_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetEModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetEModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetEModel().VideoLink));
        }

        protected void Frog_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetFrogModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetFrogModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetFrogModel().VideoLink));
        }

        //vovels long
        protected void Ilong_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetIlongModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetIlongModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetIlongModel().VideoLink));
        }

        protected void Ulong_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetUlongModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetUlongModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetUlongModel().VideoLink));
        }

        protected void Along_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetAlongModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetAlongModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetAlongModel().VideoLink));
        }

        protected void Olong_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetOlongModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetOlongModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetOlongModel().VideoLink));
        }

        protected void Erevlong_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetErevlongModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetErevlongModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetErevlongModel().VideoLink));
        }

        // vovels dipthtongs
        protected void ie_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetIEModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetIEModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetIEModel().VideoLink));
        }

        protected void ue_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetUEModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetUEModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetUEModel().VideoLink));
        }

        protected void ai_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetAIModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetAIModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetAIModel().VideoLink));
        }

        protected void oi_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetOIModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetOIModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetOIModel().VideoLink));
        }

        protected void ErevU_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetErevUModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetErevUModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetErevUModel().VideoLink));
        }

        protected void ErevE_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetErevEModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetErevEModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetErevEModel().VideoLink));
        }

        protected void au_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetAUModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetAUModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetAUModel().VideoLink));
        }

        protected void ei_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetEIModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetEIModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetEIModel().VideoLink));
        }

        //consonants voiceless
        protected void p_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetPModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetPModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetPModel().VideoLink));
        }

        protected void t_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetTModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetTModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetTModel().VideoLink));
        }

        protected void ts_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetTSModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetTSModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetTSModel().VideoLink));
        }

        protected void k_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetKModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetKModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetKModel().VideoLink));
        }

        protected void f_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetFModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetFModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetFModel().VideoLink));
        }

        protected void th_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetTHModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetTHModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetTHModel().VideoLink));
        }

        protected void s_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetSModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetSModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetSModel().VideoLink));
        }

        protected void sh_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetSHModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetSHModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetSHModel().VideoLink));
        }

        //consonants voiced

        protected void b_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetBModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetBModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetBModel().VideoLink));
        }

        protected void d_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetDModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetDModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetDModel().VideoLink));
        }

        protected void dz_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetDZModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetDZModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetDZModel().VideoLink));
        }

        protected void g_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetGModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetGModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetGModel().VideoLink));
        }

        protected void v_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetVModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetVModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetVModel().VideoLink));
        }

        protected void thVoiced_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetTHVoicedModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetTHVoicedModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetTHVoicedModel().VideoLink));
        }

        protected void z_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetZModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetZModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetZModel().VideoLink));
        }

        protected void dzz_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetDZZModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetDZZModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetDZZModel().VideoLink));
        }

        protected void m_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetMModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetMModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetMModel().VideoLink));
        }

        protected void n_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetNModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetNModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetNModel().VideoLink));
        }

        protected void nnose_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetNNoseModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetNNoseModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetNNoseModel().VideoLink));
        }

        protected void h_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetHModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetHModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetHModel().VideoLink));
        }

        protected void l_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetLModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetLModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetLModel().VideoLink));
        }

        protected void r_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetRModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetRModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetRModel().VideoLink));
        }

        protected void w_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetWModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetWModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetWModel().VideoLink));
        }

        protected void j_Click(object sender, ImageClickEventArgs e)
        {
            ViewState["VideoState"] = SoundsData.GetJModel().ViewState;
            CurrentSound.ImageUrl = SoundsData.GetJModel().ImageUrl;
            CurrentElement.Controls.Add(new LiteralControl(SoundsData.GetJModel().VideoLink));
        }

        //menuButtons
        protected void btn2Video_Click(object sender, EventArgs e) {
            if (ViewState["VideoState"] != null)
            {
                var currentSound = SoundsData.AllSoundsModels()[ViewState["VideoState"].ToString()];
                CurrentElement.Controls.Add(new LiteralControl(currentSound.VideoLink));
            }
            else
            {
                CurrentElement.Controls.Add(new LiteralControl("<h2> <<<<<<<<<<<Выберите звук, пожалуйста </h2>"));
            }
        }
       
        protected void btnExercise_Click(object sender, EventArgs e)
        {
        }
        protected void btnArticle_Click(object sender, EventArgs e)
        {
        }

        //Making sounds
        protected void MakeSound(object sender, EventArgs e)
        {

             var soundPlayer = new SoundPlayer("C:\\Users\\na_di\\OneDrive\\Documents\\Visual Studio 2015\\Projects\\Learn2Read\\Learn2Read\\wavv.wav");
             soundPlayer.Play();
        }

        //hints
        protected void ShowHintShort_Click(object sender, ImageClickEventArgs e)
        {
            CurrentElement.Controls.Add(new LiteralControl("<p>Это текст про короткие гласные</p>"));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var text = TextBox1.Text;
            var oxforPronunciation = new OxfordDictionaryRequests();
            var t = oxforPronunciation.GetTranscription(text);
            Label1.Text = t;


        }
    }
}