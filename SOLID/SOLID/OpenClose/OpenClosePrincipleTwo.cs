using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class DatabaseOpenClose
    {
        public void Add(string postMessage)
        {

        }

        public void AddAsTag(string postMessage)
        {

        }

        public void AddAsHashTag(string postMessage)
        {

        }
    }

    class OpenClosePrincipleTwoNonCompliant
    {
        public class Post
        {
            public void CreatePost(DatabaseOpenClose db, string postMessage)
            {
                if (postMessage.StartsWith("@"))
                {
                    db.AddAsTag(postMessage);
                }
                // If another message that starts with '#' comes, then another if else condition needs to be added.
                // The class will need to be heavily modified to incorporate changing requirements.
                else if (postMessage.StartsWith("#"))
                {
                    db.AddAsHashTag(postMessage);
                }
                else
                {
                    db.Add(postMessage);
                }
            }
        }
    }

    class OpenClosePrincipleTwo
    {
        /*
         * By using Inheritance, it is much easier to create extended behaviour to the Post object by oerriding the CreatePost() method.
         */
        public class Post
        {
            public virtual void CreatePost(DatabaseOpenClose db, string postMessage)
            {
                db.Add(postMessage);
            }
        }

        public class TagPost : Post
        {
            public override void CreatePost(DatabaseOpenClose db, string postMessage)
            {
                db.AddAsTag(postMessage);
            }
        }

        public class HashTagPost : Post
        {
            public override void CreatePost(DatabaseOpenClose db, string postMessage)
            {
                db.AddAsHashTag(postMessage);
            }
        }
    }
}
