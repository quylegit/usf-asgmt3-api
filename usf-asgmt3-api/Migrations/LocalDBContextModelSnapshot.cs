﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using usf_asgmt3_api.Integration.LocalDataRepo;

namespace usf_asgmt3_api.Migrations
{
    [DbContext(typeof(LocalDBContext))]
    partial class LocalDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("usf_asgmt3_api.model.Company", b =>
                {
                    b.Property<string>("ticker")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cik");

                    b.Property<string>("industry_category");

                    b.Property<string>("lei");

                    b.Property<long?>("market_cap");

                    b.Property<string>("name");

                    b.HasKey("ticker");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("usf_asgmt3_api.model.Company_Detail", b =>
                {
                    b.Property<string>("symbol")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEO");

                    b.Property<string>("companyName");

                    b.Property<string>("description");

                    b.Property<string>("exchange");

                    b.Property<string>("industry");

                    b.Property<string>("issueType");

                    b.Property<string>("sector");

                    b.Property<string>("website");

                    b.HasKey("symbol");

                    b.ToTable("Company_Details");
                });

            modelBuilder.Entity("usf_asgmt3_api.model.Company_Dividend", b =>
                {
                    b.Property<string>("symbol");

                    b.Property<string>("exDate");

                    b.Property<float>("amount");

                    b.Property<string>("declaredDate");

                    b.Property<string>("flag");

                    b.Property<string>("indicated");

                    b.Property<string>("paymentDate");

                    b.Property<string>("qualified");

                    b.Property<string>("recordDate");

                    b.Property<string>("type");

                    b.HasKey("symbol", "exDate");

                    b.ToTable("Company_Dividends");
                });

            modelBuilder.Entity("usf_asgmt3_api.model.Company_Financial", b =>
                {
                    b.Property<string>("symbol");

                    b.Property<string>("reportDate");

                    b.Property<long?>("cashChange");

                    b.Property<long?>("cashFlow");

                    b.Property<long?>("costOfRevenue");

                    b.Property<long?>("currentAssets");

                    b.Property<long?>("currentCash");

                    b.Property<long?>("currentDebt");

                    b.Property<long?>("grossProfit");

                    b.Property<long?>("netIncome");

                    b.Property<long?>("operatingExpense");

                    b.Property<long?>("operatingIncome");

                    b.Property<long?>("operatingRevenue");

                    b.Property<long?>("researchAndDevelopment");

                    b.Property<long?>("shareholderEquity");

                    b.Property<long?>("totalAssets");

                    b.Property<long?>("totalCash");

                    b.Property<long?>("totalDebt");

                    b.Property<long?>("totalLiabilities");

                    b.Property<long?>("totalRevenue");

                    b.HasKey("symbol", "reportDate");

                    b.ToTable("Company_Financials");
                });

            modelBuilder.Entity("usf_asgmt3_api.model.Company_Price", b =>
                {
                    b.Property<string>("symbol");

                    b.Property<string>("date");

                    b.Property<float>("close");

                    b.Property<float>("high");

                    b.Property<float>("low");

                    b.Property<float>("open");

                    b.Property<int>("volume");

                    b.HasKey("symbol", "date");

                    b.ToTable("Company_Prices");
                });

            modelBuilder.Entity("usf_asgmt3_api.model.Symbol", b =>
                {
                    b.Property<string>("symbol")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("date");

                    b.Property<string>("iexId");

                    b.Property<bool>("isEnabled");

                    b.Property<string>("name");

                    b.Property<string>("type");

                    b.HasKey("symbol");

                    b.ToTable("Symbols");
                });
#pragma warning restore 612, 618
        }
    }
}
