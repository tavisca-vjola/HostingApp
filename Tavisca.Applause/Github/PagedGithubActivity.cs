using System;
using System.Collections.Generic;
using System.Text;

namespace Tavisca.Applause
{
    public class PagedGithubActivity : PagedList
    {
        public List<GithubActivity> PagedActivity {get; set; }
}
}
