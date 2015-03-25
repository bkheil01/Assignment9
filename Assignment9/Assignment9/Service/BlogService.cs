using Assignment9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment9.Service
{
    public class BlogService
    {
            private static List<Blog> Blogs;
            static BlogService()
            {
                Blogs = populateBlogs();
            }
            public void resetService()
            {
                Blogs = populateBlogs();
            }
            public List<Blog> getBlogs()
            {
                return Blogs;
            }
            public void updateBlog(Blog Blog)
            {
                removeBlog(Blog);
                addBlog(Blog);
            }
            public Blog getBlog(int id)
            {
                Blog foundBlog = new Blog();
                foreach (Blog Blog in Blogs)
                {
                    if (Blog.BlogID == id)
                    {
                        foundBlog = Blog;
                    }
                }
                return foundBlog;
            }
            public void removeBlog(Blog s)
            {
                //todo: refactor this with get by id and them removing later
                Blog Blog = getBlog(s.BlogID);
                Blogs.Remove(Blog);
            }
            public void addBlog(Blog s)
            {
                int max = 0;
                if (s.BlogID == 0)
                {
                    //find max Blog id
                    foreach (Blog Blog in Blogs)
                    {
                        if (Blog.BlogID > max)
                        {
                            max = Blog.BlogID;
                        }
                    }
                    s.BlogID = max + 1;
                }
                //add Blog
                Blogs.Add(s);
            }
            private static List<Blog> populateBlogs()
            {
                List<Blog> Blogs = new List<Blog>();
                Blog b = new Blog();
                b.Name = "Dog";
                b.BlogID = 1;
                b.About = "We keep pets for pleasure. Some people keep dogs as pets. Others keep birds, pigeon or rabbits as pets. Pets are like our family members. They are carefully fed. Pet owners always protect their pets from danger. I have a peg dog. Its name is Jack. Jack is very beautiful. The body of My pet dog is covered with soft white fur. The eyes of Jack are large and dark. The dog is very active and playful. Jack takes rice and meat as food. It is very obedient. Jack guards our house at night. When I come back from school, My pet dog begins to jump in joy. I love my pet very much. My parents also love the dog. Very often, I play with Jack.";
                b.Date = "3/23/2015";
                b.Favorite = "Golden Retriever";
                b.Image = "http://www.cdc.gov/animalimportation/images/dog2.jpg";
                b.Last = "Irish Terrier";
                b.Past = "Jack Russell";
                b.Past1 = "";
                b.Past2 = "";
                b.Past3 = "";
                b.Past4 = "";
                  
                Blogs.Add(b);
                return Blogs;
          }
    }
}
