﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieFrontEnd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MovieEntities : DbContext
    {
        public MovieEntities()
            : base("name=MovieEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cmt_ImageList> Cmt_ImageList { get; set; }
        public virtual DbSet<CnQ> CnQs { get; set; }
        public virtual DbSet<CnQStatusList> CnQStatusLists { get; set; }
        public virtual DbSet<CnQType> CnQTypes { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Hashtag> Hashtags { get; set; }
        public virtual DbSet<ImageList> ImageLists { get; set; }
        public virtual DbSet<MovieCmt_Hash> MovieCmt_Hash { get; set; }
        public virtual DbSet<MovieCmt> MovieCmts { get; set; }
        public virtual DbSet<Reply> Replies { get; set; }
        public virtual DbSet<StatusList> StatusLists { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberAction> MemberActions { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<MovieActorsList> MovieActorsLists { get; set; }
        public virtual DbSet<MovieCountriesList> MovieCountriesLists { get; set; }
        public virtual DbSet<MovieDirectorsList> MovieDirectorsLists { get; set; }
        public virtual DbSet<MovieImagesList> MovieImagesLists { get; set; }
        public virtual DbSet<MovieLanguagesList> MovieLanguagesLists { get; set; }
        public virtual DbSet<MovieRating> MovieRatings { get; set; }
        public virtual DbSet<MovieTypesList> MovieTypesLists { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<CreditCardType> CreditCardTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<OrderStatusLog> OrderStatusLogs { get; set; }
        public virtual DbSet<PayType> PayTypes { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CouponList> CouponLists { get; set; }
        public virtual DbSet<CouponType> CouponTypes { get; set; }
        public virtual DbSet<ProductsType> ProductsTypes { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public virtual DbSet<PlayTimeDetail> PlayTimeDetails { get; set; }
        public virtual DbSet<Seat> Seats { get; set; }
        public virtual DbSet<SeatStatu> SeatStatus { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<Theater> Theaters { get; set; }
        public virtual DbSet<TheaterClass> TheaterClasses { get; set; }
        public virtual DbSet<TicketClass> TicketClasses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
