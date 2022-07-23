using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ModulMon.Models
{
    public partial class PPortalContext : DbContext
    {
        public PPortalContext()
        {
        }

        public PPortalContext(DbContextOptions<PPortalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ErrorCode> ErrorCodes { get; set; } = null!;
        public virtual DbSet<GlobalCountryRegionCode> GlobalCountryRegionCodes { get; set; } = null!;
        public virtual DbSet<GlobalTimezone> GlobalTimezones { get; set; } = null!;
        public virtual DbSet<Line> Lines { get; set; } = null!;
        public virtual DbSet<MailRecipient> MailRecipients { get; set; } = null!;
        public virtual DbSet<Material> Materials { get; set; } = null!;
        public virtual DbSet<MaterialImage> MaterialImages { get; set; } = null!;
        public virtual DbSet<MaterialRepma> MaterialRepmas { get; set; } = null!;
        public virtual DbSet<Menue> Menues { get; set; } = null!;
        public virtual DbSet<NewsTickerMessage> NewsTickerMessages { get; set; } = null!;
        public virtual DbSet<NewsTickerProject> NewsTickerProjects { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<Plant> Plants { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<ProjectBreakSet> ProjectBreakSets { get; set; } = null!;
        public virtual DbSet<ProjectGroup> ProjectGroups { get; set; } = null!;
        public virtual DbSet<ProjectMailRecipient> ProjectMailRecipients { get; set; } = null!;
        public virtual DbSet<ProjectShiftSet> ProjectShiftSets { get; set; } = null!;
        public virtual DbSet<Station> Stations { get; set; } = null!;
        public virtual DbSet<Usr> Usrs { get; set; } = null!;
        public virtual DbSet<UsrLog> UsrLogs { get; set; } = null!;
        public virtual DbSet<UsrRight> UsrRights { get; set; } = null!;
        public virtual DbSet<VerificationErrorCode> VerificationErrorCodes { get; set; } = null!;
        public virtual DbSet<VerificationSample> VerificationSamples { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=mssqlwupbpp;Database=PPortal;User Id=sa8300;Password=Release+2;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<ErrorCode>(entity =>
            {
                entity.HasKey(e => new { e.ErrorCode1, e.ProjectId });

                entity.ToTable("error_codes");

                entity.Property(e => e.ErrorCode1).HasColumnName("error_code");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ActionsTaken)
                    .HasColumnType("text")
                    .HasColumnName("actions_taken");

                entity.Property(e => e.CauseDescription)
                    .HasColumnType("text")
                    .HasColumnName("cause_description");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUserId).HasColumnName("change_user_id");

                entity.Property(e => e.LastFound)
                    .HasColumnType("datetime")
                    .HasColumnName("last_found");

                entity.Property(e => e.LongDescription)
                    .HasColumnType("text")
                    .HasColumnName("long_description");

                entity.Property(e => e.NotificationThreshold).HasColumnName("notification_threshold");

                entity.Property(e => e.OkStatus).HasColumnName("ok_status");

                entity.Property(e => e.ShortDescription)
                    .HasMaxLength(50)
                    .HasColumnName("short_description");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ErrorCodes)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_error_codes_project");
            });

            modelBuilder.Entity<GlobalCountryRegionCode>(entity =>
            {
                entity.HasKey(e => e.RegionString);

                entity.ToTable("global_country_region_code");

                entity.Property(e => e.RegionString)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("region_string")
                    .IsFixedLength();

                entity.Property(e => e.Country)
                    .HasMaxLength(20)
                    .HasColumnName("country");
            });

            modelBuilder.Entity<GlobalTimezone>(entity =>
            {
                entity.HasKey(e => e.TimezoneId);

                entity.ToTable("global_timezones");

                entity.Property(e => e.TimezoneId)
                    .HasMaxLength(50)
                    .HasColumnName("timezone_id");

                entity.Property(e => e.DaylightSaving).HasColumnName("daylight_saving");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TimeDifference)
                    .HasMaxLength(9)
                    .HasColumnName("time_difference");

                entity.Property(e => e.TimezoneId2)
                    .HasMaxLength(50)
                    .HasColumnName("timezone_id_2");

                entity.Property(e => e.TimezoneId3)
                    .HasMaxLength(50)
                    .HasColumnName("timezone_id_3");
            });

            modelBuilder.Entity<Line>(entity =>
            {
                entity.ToTable("line");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUserId).HasColumnName("change_user_id");

                entity.Property(e => e.DetailGrpId).HasColumnName("detail_grp_id");

                entity.Property(e => e.FihPpmTarget).HasColumnName("fih_ppm_target");

                entity.Property(e => e.Lg)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("lg");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.OeeReport).HasColumnName("oee_report");

                entity.Property(e => e.OeeReportPos).HasColumnName("oee_report_pos");

                entity.Property(e => e.OnePieceFlow).HasColumnName("one_piece_flow");

                entity.Property(e => e.Pos).HasColumnName("pos");

                entity.Property(e => e.PrjId).HasColumnName("prj_id");

                entity.Property(e => e.StSerial).HasColumnName("st_serial");

                entity.Property(e => e.TwoPtWt).HasColumnName("two_pt_wt");

                entity.Property(e => e.ZielOee)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("ziel_oee");

                entity.HasOne(d => d.Prj)
                    .WithMany(p => p.Lines)
                    .HasForeignKey(d => d.PrjId)
                    .HasConstraintName("FK_line_project");
            });

            modelBuilder.Entity<MailRecipient>(entity =>
            {
                entity.ToTable("mail_recipient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(100)
                    .HasColumnName("mail_address");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Material>(entity =>
            {
                entity.ToTable("material");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Akkord).HasColumnName("akkord");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUsrId).HasColumnName("change_usr_id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .HasColumnName("descr");

                entity.Property(e => e.IsRepresentative).HasColumnName("is_representative");

                entity.Property(e => e.MatNum)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("mat_num")
                    .IsFixedLength();

                entity.Property(e => e.NumWorkers).HasColumnName("num_workers");

                entity.Property(e => e.NumWorkersMax).HasColumnName("num_workers_max");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Vt)
                    .HasColumnType("numeric(6, 2)")
                    .HasColumnName("vt");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Materials)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_material_project");
            });

            modelBuilder.Entity<MaterialImage>(entity =>
            {
                entity.ToTable("material_images");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.MatId).HasColumnName("mat_id");

                entity.Property(e => e.ScreenNum).HasColumnName("screen_num");

                entity.HasOne(d => d.Mat)
                    .WithMany(p => p.MaterialImages)
                    .HasForeignKey(d => d.MatId)
                    .HasConstraintName("FK_material_images_material");
            });

            modelBuilder.Entity<MaterialRepma>(entity =>
            {
                entity.ToTable("material_repma");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descr");

                entity.Property(e => e.Direct).HasColumnName("direct");

                entity.Property(e => e.Ind)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ind")
                    .IsFixedLength();

                entity.Property(e => e.MatNum)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Mat_num")
                    .IsFixedLength();

                entity.Property(e => e.PrjId).HasColumnName("prj_id");

                entity.Property(e => e.Vgz).HasColumnName("vgz");

                entity.HasOne(d => d.Prj)
                    .WithMany(p => p.MaterialRepmas)
                    .HasForeignKey(d => d.PrjId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_material_repma_project");
            });

            modelBuilder.Entity<Menue>(entity =>
            {
                entity.ToTable("menue");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("text")
                    .HasColumnName("code");

                entity.Property(e => e.Descr)
                    .HasColumnType("text")
                    .HasColumnName("descr");

                entity.Property(e => e.Hide).HasColumnName("hide");

                entity.Property(e => e.Link)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("link");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pos).HasColumnName("pos");
            });

            modelBuilder.Entity<NewsTickerMessage>(entity =>
            {
                entity.ToTable("news_ticker_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUserId).HasColumnName("change_user_id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.CreateUserId).HasColumnName("create_user_id");

                entity.Property(e => e.MessageTextShort).HasColumnName("message_text_short");

                entity.Property(e => e.NewsTickerProjectId).HasColumnName("news_ticker_project_id");

                entity.Property(e => e.ValidFrom)
                    .HasColumnType("date")
                    .HasColumnName("valid_from");

                entity.Property(e => e.ValidTo)
                    .HasColumnType("date")
                    .HasColumnName("valid_to");
            });

            modelBuilder.Entity<NewsTickerProject>(entity =>
            {
                entity.ToTable("news_ticker_project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUserId).HasColumnName("change_user_id");

                entity.Property(e => e.IframeRefreshRate).HasColumnName("iframe_refresh_rate");

                entity.Property(e => e.NewsTickerProjectName)
                    .HasMaxLength(50)
                    .HasColumnName("news_ticker_project_name");

                entity.Property(e => e.PageContentUrl).HasColumnName("page_content_url");

                entity.Property(e => e.PageHeader)
                    .HasMaxLength(50)
                    .HasColumnName("page_header");

                entity.Property(e => e.PlantNum).HasColumnName("plant_num");

                entity.Property(e => e.ProdviewScreenId).HasColumnName("prodview_screen_id");

                entity.Property(e => e.ScreenRefreshRate).HasColumnName("screen_refresh_rate");

                entity.Property(e => e.ScrollAmount).HasColumnName("scroll_amount");

                entity.Property(e => e.ScrollDelay).HasColumnName("scroll_delay");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("notifications");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorCode).HasColumnName("error_code");

                entity.Property(e => e.NotificationTime)
                    .HasColumnType("datetime")
                    .HasColumnName("notification_time");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.Station).HasColumnName("station");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_notifications_project");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.ToTable("plant");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country");

                entity.Property(e => e.IntName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("int_name");

                entity.Property(e => e.LocalFormatSetting)
                    .HasMaxLength(50)
                    .HasColumnName("local_format_setting");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.PlantNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("plant_num")
                    .IsFixedLength();

                entity.Property(e => e.PlantShort)
                    .HasMaxLength(5)
                    .HasColumnName("plant_short");

                entity.Property(e => e.Pos).HasColumnName("pos");

                entity.Property(e => e.TimezoneId)
                    .HasMaxLength(50)
                    .HasColumnName("timezone_id");

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("town");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("project");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnalysePerStation).HasColumnName("analyse_per_station");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUserId).HasColumnName("change_user_id");

                entity.Property(e => e.DbName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("db_name");

                entity.Property(e => e.DbPasswd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("db_passwd");

                entity.Property(e => e.DbServer)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("db_server");

                entity.Property(e => e.DbUsr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("db_usr");

                entity.Property(e => e.FihPpmTarget).HasColumnName("fih_ppm_target");

                entity.Property(e => e.Hidden).HasColumnName("hidden");

                entity.Property(e => e.Kst)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("kst")
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.NotificationActive).HasColumnName("notification_active");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.Pos).HasColumnName("pos");

                entity.Property(e => e.ProjectGroupId).HasColumnName("project_group_id");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK_project_plant");
            });

            modelBuilder.Entity<ProjectBreakSet>(entity =>
            {
                entity.ToTable("project_break_set");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DownTime).HasColumnName("down_time");

                entity.Property(e => e.Duration)
                    .HasColumnType("numeric(3, 0)")
                    .HasColumnName("duration");

                entity.Property(e => e.Editable).HasColumnName("editable");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ShiftSetId).HasColumnName("shift_set_id");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");

                entity.Property(e => e.StdActive).HasColumnName("std_active");

                entity.Property(e => e.StopCounting).HasColumnName("stop_counting");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectBreakSets)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_project_break_set_project");
            });

            modelBuilder.Entity<ProjectGroup>(entity =>
            {
                entity.ToTable("project_group");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProjectGroupName)
                    .HasMaxLength(50)
                    .HasColumnName("project_group_name");
            });

            modelBuilder.Entity<ProjectMailRecipient>(entity =>
            {
                entity.ToTable("project_mail_recipient");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.RecipientId).HasColumnName("recipient_id");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectMailRecipients)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_project_mail_recipient_project");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.ProjectMailRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("FK_project_mail_recipient_mail_recipient");
            });

            modelBuilder.Entity<ProjectShiftSet>(entity =>
            {
                entity.ToTable("project_shift_set");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChangeTime)
                    .HasColumnType("datetime")
                    .HasColumnName("change_time");

                entity.Property(e => e.ChangeUsrId).HasColumnName("change_usr_id");

                entity.Property(e => e.ProjectId).HasColumnName("project_id");

                entity.Property(e => e.ShiftEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("shift_end_time");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .HasColumnName("shift_name");

                entity.Property(e => e.ShiftStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("shift_start_time");

                entity.Property(e => e.ValidFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_from");

                entity.Property(e => e.ValidTo)
                    .HasColumnType("datetime")
                    .HasColumnName("valid_to");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectShiftSets)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_project_shift_set_project");
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("station");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DbValue).HasColumnName("db_value");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("description");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Pos).HasColumnName("pos");

                entity.Property(e => e.VolumeLine).HasColumnName("volume_line");

                entity.Property(e => e.VolumeProject).HasColumnName("volume_project");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.Stations)
                    .HasForeignKey(d => d.LineId)
                    .HasConstraintName("FK_station_line");
            });

            modelBuilder.Entity<Usr>(entity =>
            {
                entity.ToTable("usr");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BroseId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("brose_id");

                entity.Property(e => e.Descr)
                    .HasColumnType("text")
                    .HasColumnName("descr");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("datetime")
                    .HasColumnName("last_login");

                entity.Property(e => e.LocalFormatSetting)
                    .HasMaxLength(50)
                    .HasColumnName("local_format_setting");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.StandardPlant).HasColumnName("standard_plant");
            });

            modelBuilder.Entity<UsrLog>(entity =>
            {
                entity.ToTable("usr_log");

                entity.HasIndex(e => e.UsrId, "IX_usr_id")
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IpAdr)
                    .HasMaxLength(15)
                    .HasColumnName("ip_adr")
                    .IsFixedLength();

                entity.Property(e => e.Param).HasColumnName("param");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Url).HasColumnName("url");

                entity.Property(e => e.UsrId).HasColumnName("usr_id");

                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.UsrLogs)
                    .HasForeignKey(d => d.UsrId)
                    .HasConstraintName("FK_usr_log_usr");
            });

            modelBuilder.Entity<UsrRight>(entity =>
            {
                entity.ToTable("usr_rights");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AllowMid).HasColumnName("allow_mid");

                entity.Property(e => e.MenuId).HasColumnName("menu_id");

                entity.Property(e => e.UsrId).HasColumnName("usr_id");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.UsrRights)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_usr_rights_menue");

                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.UsrRights)
                    .HasForeignKey(d => d.UsrId)
                    .HasConstraintName("FK_usr_rights_usr");
            });

            modelBuilder.Entity<VerificationErrorCode>(entity =>
            {
                entity.ToTable("verification_error_code");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErrorActionNumber).HasColumnName("error_action_number");

                entity.Property(e => e.ErrorCode).HasColumnName("error_code");

                entity.Property(e => e.ErrorDescription).HasColumnName("error_description");

                entity.Property(e => e.ErrorStepNumber).HasColumnName("error_step_number");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.SampleId).HasColumnName("sample_id");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.VerificationErrorCodes)
                    .HasForeignKey(d => d.SampleId)
                    .HasConstraintName("FK_verification_error_code_verification_sample");
            });

            modelBuilder.Entity<VerificationSample>(entity =>
            {
                entity.HasKey(e => e.SampleId);

                entity.ToTable("verification_sample");

                entity.Property(e => e.SampleId).HasColumnName("sample_id");

                entity.Property(e => e.ErrorDescription).HasColumnName("error_description");

                entity.Property(e => e.LineId).HasColumnName("line_id");

                entity.Property(e => e.MaterialNumber)
                    .HasMaxLength(10)
                    .HasColumnName("material_number");

                entity.Property(e => e.Note).HasColumnName("note");

                entity.Property(e => e.ProgramNumber).HasColumnName("program_number");

                entity.Property(e => e.SampleNumber).HasColumnName("sample_number");

                entity.HasOne(d => d.Line)
                    .WithMany(p => p.VerificationSamples)
                    .HasForeignKey(d => d.LineId)
                    .HasConstraintName("FK_verification_sample_line");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
