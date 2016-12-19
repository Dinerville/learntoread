using System.Collections.Generic;

namespace Learn2Read
{
    public class SoundModel
    {
        public string VideoLink { get; set; }
        public List<WordModel> WordsList { get; set; }
        public string ImageUrl { get; set; }
        public string ViewState { get; set; }
    }
}