﻿using Blog.Backend.Common.Utils;
using Blog.Backend.DataAccess.Repository;

namespace Blog.Backend.DataAccess.Seed
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.lbConsole = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(12, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(294, 23);
            this.BtnGenerate.TabIndex = 5;
            this.BtnGenerate.Text = "Generate Data";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
            // 
            // lbConsole
            // 
            this.lbConsole.FormattingEnabled = true;
            this.lbConsole.Location = new System.Drawing.Point(13, 42);
            this.lbConsole.Name = "lbConsole";
            this.lbConsole.Size = new System.Drawing.Size(293, 251);
            this.lbConsole.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 303);
            this.Controls.Add(this.lbConsole);
            this.Controls.Add(this.BtnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I Can Haz Seeds!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private readonly IAddressRepository _addressRepository = new AddressRepository();
        private readonly ICommentLikeRepository _commentLikeRepository = new CommentLikeRepository();
        private readonly ICommentRepository _commentRepository = new CommentRepository();
        private readonly IEducationRepository _educationRepository = new EducationRepository();
        private readonly IEducationTypeRepository _educationTypeRepository = new EducationTypeRepository();
        private readonly IHobbyRepository _hobbyRepository = new HobbyRepository();
        private readonly IAlbumRepository _albumRepository = new AlbumRepository();
        private readonly IMediaRepository _mediaRepository = new MediaRepository();
        private readonly IPostContentRepository _postContentRepository = new PostContentRepository();
        private readonly IPostLikeRepository _postLikeRepository = new PostLikeRepository();
        private readonly IPostRepository _postRepository = new PostRepository();
        private readonly ITagRepository _tagRepository = new TagRepository();
        private readonly IUserRepository _userRepository = new UserRepository();
        private readonly IImageHelper _imageHelper = new ImageHelper();
        private System.Windows.Forms.ListBox lbConsole;
    }
}

