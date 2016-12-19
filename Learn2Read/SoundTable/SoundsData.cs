using System;
using System.Collections.Generic;

namespace Learn2Read
{
    public class SoundsData
    {
        public static Dictionary<string,SoundModel> AllSoundsModels()
        {
            var listOfSounds = new Dictionary<string, SoundModel>();
            listOfSounds.Add(GetIModel().ViewState, GetIModel());
            listOfSounds.Add(GetUModel().ViewState, GetUModel());
            listOfSounds.Add(GetAModel().ViewState, GetAModel());
            listOfSounds.Add(GetArevModel().ViewState, GetArevModel());
            listOfSounds.Add(GetErevModel().ViewState, GetErevModel());
            listOfSounds.Add(GetEModel().ViewState, GetEModel());
            listOfSounds.Add(GetFrogModel().ViewState, GetFrogModel());
            listOfSounds.Add(GetIlongModel().ViewState, GetIlongModel());
            listOfSounds.Add(GetUlongModel().ViewState, GetUlongModel());
            listOfSounds.Add(GetAlongModel().ViewState, GetAlongModel());
            listOfSounds.Add(GetOlongModel().ViewState, GetOlongModel());
            listOfSounds.Add(GetErevlongModel().ViewState, GetErevlongModel());
            listOfSounds.Add(GetIEModel().ViewState, GetIEModel());
            listOfSounds.Add(GetUEModel().ViewState, GetUEModel());
            listOfSounds.Add(GetAIModel().ViewState, GetAIModel());
            listOfSounds.Add(GetOIModel().ViewState, GetOIModel());
            listOfSounds.Add(GetErevUModel().ViewState, GetErevUModel());
            listOfSounds.Add(GetErevEModel().ViewState, GetErevEModel());
            listOfSounds.Add(GetAUModel().ViewState, GetAUModel());
            listOfSounds.Add(GetEIModel().ViewState, GetEIModel());
            listOfSounds.Add(GetPModel().ViewState, GetPModel());
            listOfSounds.Add(GetTModel().ViewState, GetTModel());
            listOfSounds.Add(GetTSModel().ViewState, GetTSModel());
            listOfSounds.Add(GetKModel().ViewState, GetKModel());
            listOfSounds.Add(GetFModel().ViewState, GetFModel());
            listOfSounds.Add(GetTHModel().ViewState, GetTHModel());
            listOfSounds.Add(GetSModel().ViewState, GetSModel());
            listOfSounds.Add(GetSHModel().ViewState, GetSHModel());
            listOfSounds.Add(GetBModel().ViewState, GetBModel());
            listOfSounds.Add(GetDModel().ViewState, GetDModel());
            listOfSounds.Add(GetDZModel().ViewState, GetDZModel());
            listOfSounds.Add(GetGModel().ViewState, GetGModel());
            listOfSounds.Add(GetVModel().ViewState, GetVModel());
            listOfSounds.Add(GetTHVoicedModel().ViewState, GetTHVoicedModel());
            listOfSounds.Add(GetZModel().ViewState, GetZModel());
            listOfSounds.Add(GetDZZModel().ViewState, GetDZZModel());
            listOfSounds.Add(GetMModel().ViewState, GetMModel());
            listOfSounds.Add(GetNModel().ViewState, GetNModel());
            listOfSounds.Add(GetNNoseModel().ViewState, GetNNoseModel());
            listOfSounds.Add(GetHModel().ViewState, GetHModel());
            listOfSounds.Add(GetLModel().ViewState, GetLModel());
            listOfSounds.Add(GetRModel().ViewState, GetRModel());
            listOfSounds.Add(GetWModel().ViewState, GetWModel());
            listOfSounds.Add(GetJModel().ViewState, GetJModel());
            return listOfSounds;
        }

        public static SoundModel GetIModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "I";
            IModel.ImageUrl = "../images/soundtable/i.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/TNFKG0yvDx4\" frameborder =\"0\" allowfullscreen></iframe>";
            
            IModel.WordsList = WordsData.GetIWordsModels();
            return IModel;
        }

        public static SoundModel GetUModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "U";
            IModel.ImageUrl = "../images/soundtable/u.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/eJ7dM_LU9t4\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }


        public static SoundModel GetAModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "A";
            IModel.ImageUrl = "../images/soundtable/a.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/PZwKFFp7V50\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetArevModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "ARev";
            IModel.ImageUrl = "../images/soundtable/areverse.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/MAk-XtHsyzM\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetErevModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "ERev";
            IModel.ImageUrl = "../images/soundtable/ereverse.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/wg0P0oYkniE\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetEModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "E";
            IModel.ImageUrl = "../images/soundtable/e.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/hLN1cdSTDo8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetFrogModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Frog";
            IModel.ImageUrl = "../images/soundtable/frog.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/qVhaIHk88a8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        //vovels long
        public static SoundModel GetIlongModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Ilong";
            IModel.ImageUrl = "../images/soundtable/ilong.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/RZmGzSb-6OM\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetUlongModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Ulong";
            IModel.ImageUrl = "../images/soundtable/ulong.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/mnKEGLuEzV4\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetAlongModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Along";
            IModel.ImageUrl = "../images/soundtable/along.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/uDHMuMQdBNw\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetOlongModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Olong";
            IModel.ImageUrl = "../images/soundtable/olong.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/KHllC40_u1Q\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetErevlongModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Erevlong";
            IModel.ImageUrl = "../images/soundtable/ereverselong.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/zSJJWHymEPw\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        // vovels dipthtongs
        public static SoundModel GetIEModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "IE";
            IModel.ImageUrl = "../images/soundtable/ie.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/vC0h4S0YPJc\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetUEModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "UE";
            IModel.ImageUrl = "../images/soundtable/ue.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/nHSqluHrD-U\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetAIModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "AI";
            IModel.ImageUrl = "../images/soundtable/ai.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/Hb8COxAtl14\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetOIModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "OI";
            IModel.ImageUrl = "../images/soundtable/oi.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/lFRrEI85IcM\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetErevUModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "ErevU";
            IModel.ImageUrl = "../images/soundtable/ereverseu.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/r1BRCG0P9C8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetErevEModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "ErevE";
            IModel.ImageUrl = "../images/soundtable/ereversee.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/0J7-5maJJIk\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetAUModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "AU";
            IModel.ImageUrl = "../images/soundtable/au.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/9WDnVMQIaTs\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetEIModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "EI";
            IModel.ImageUrl = "../images/soundtable/ei.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/5FMPlqlFt9g\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        //consonants voiceless
        public static SoundModel GetPModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "P";
            IModel.ImageUrl = "../images/soundtable/p.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/AZRREr7DqqM\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetTModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "T";
            IModel.ImageUrl = "../images/soundtable/t.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/0T1QYByMxrs\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetTSModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "TS";
            IModel.ImageUrl = "../images/soundtable/ts.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/PykxZ5kkrjs\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetKModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "K";
            IModel.ImageUrl = "../images/soundtable/k.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/d1jyIpAmLe8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetFModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "F";
            IModel.ImageUrl = "../images/soundtable/f.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/vE12RFyH-hY\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetTHModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "TH";
            IModel.ImageUrl = "../images/soundtable/th.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/b4Aj3k65HSo\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetSModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "S";
            IModel.ImageUrl = "../images/soundtable/s.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/QtH3vRXmvvo\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetSHModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "SH";
            IModel.ImageUrl = "../images/soundtable/sh.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/NF92RdZC6wE\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        //consonants voiced

        public static SoundModel GetBModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "B";
            IModel.ImageUrl = "../images/soundtable/b.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/yP7aCKO6bTE\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetDModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "D";
            IModel.ImageUrl = "../images/soundtable/d.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/qA5ZYC89oso\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetDZModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "DZ";
            IModel.ImageUrl = "../images/soundtable/dz.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/0IeQmGdo7gQ\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetGModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "G";
            IModel.ImageUrl = "../images/soundtable/g.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/9eAqj9EfeK0\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetVModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "V";
            IModel.ImageUrl = "../images/soundtable/v.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/mO04G0v5a_c\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetTHVoicedModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "THVoiced";
            IModel.ImageUrl = "../images/soundtable/thvoiced.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/tu1t3Fn5Lw8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetZModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "Z";
            IModel.ImageUrl = "../images/soundtable/z.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/o1ZvmX80t7Q\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetDZZModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "DZZ";
            IModel.ImageUrl = "../images/soundtable/dzz.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/bTxeAiBF61I\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetMModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "M";
            IModel.ImageUrl = "../images/soundtable/m.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/0Te4Us8Tsv8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetNModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "N";
            IModel.ImageUrl = "../images/soundtable/n.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/qkgucMjv4T0\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetNNoseModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "NNose";
            IModel.ImageUrl = "../images/soundtable/nnose.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/rgWse3tloTw\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetHModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "H";
            IModel.ImageUrl = "../images/soundtable/h.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/DM_gN6imoC8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetLModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "L";
            IModel.ImageUrl = "../images/soundtable/l.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/CwWLgmMk0Z0\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetRModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "R";
            IModel.ImageUrl = "../images/soundtable/r.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/Lxuo14hjP_8\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetWModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "W";
            IModel.ImageUrl = "../images/soundtable/w.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/HzhPB1hXG-o\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

        public static SoundModel GetJModel()
        {
            var IModel = new SoundModel();
            IModel.ViewState = "J";
            IModel.ImageUrl = "../images/soundtable/j.png";
            IModel.VideoLink = "<iframe width=\"854\" height=\"480\" src=\"https://www.youtube.com/embed/_Fi9E6Yw-qg\" frameborder=\"0\" allowfullscreen></iframe>";
            return IModel;
        }

    }
}