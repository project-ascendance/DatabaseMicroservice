using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseMicroservice.Models
{
    internal class DoThings
    {
        private CMSContentContext _db;

        public DoThings()
        {
            _db = new CMSContentContext();
        }
        public void Run1()
        {
            var test = new TextFragment();
            var test2 = new TextFragment();
            test.NextFragment = test2;
            test.TotalFragmentCount = 2; test2.TotalFragmentCount = 2;
            test.BelongsTo = "News1";
            test.FragmentId = test.BelongsTo + "_0";
            test2.BelongsTo = "News1";
            test2.FragmentId = test2.BelongsTo + "_1";
            test.Body = "Teeest 1";
            test2.Body = "Teest 2";
            test2.NextFragment = null;
            _db.Add(test2);
            _db.Add(test);
            _db.SaveChanges();
        }
        public void Run2()
        {
            var test = _db.TextFragments.Where(x => x.FragmentId == "News1_0" && x.BelongsTo == "News1").Include("NextFragment").FirstOrDefault();
            System.Console.WriteLine(test.Body);
            System.Console.WriteLine((test.NextFragment as TextFragment).Body);
        }
    }
}
