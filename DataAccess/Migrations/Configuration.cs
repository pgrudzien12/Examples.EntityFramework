namespace WebApplication.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            context.Posts.Add(new Post()
            {
                Content = "Post content",
                CreationDate = new DateTime(2015, 10, 17),
                ModificationDate = new DateTime(2015, 10, 17),
                Title = "First blog post"
            });
        }
    }
}
