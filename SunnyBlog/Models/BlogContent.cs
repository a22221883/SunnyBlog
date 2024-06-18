using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyBlog.Models
{
    public class BlogContent
    {
        public int Id { get; set; } // 自動生成的文章ID
        public string Title { get; set; } // 標題
        public string Category { get; set; } // 分類
        public string Content { get; set; } // 內容
        public string Author { get; set; } // 作者
        //public DateTime DatePublished { get; set; } // 發佈日期
        /*public List<string> Tags { get; set; } // 標籤
        public string Excerpt { get; set; } // 摘要
        public int Views { get; set; } // 瀏覽次數
        public int Likes { get; set; } // 喜歡數
        public string FeaturedImage { get; set; } // 特色圖片
        public string Slug { get; set; } // 簡短標題（URL用）
        public string Status { get; set; } // 狀態（草稿、已發佈等）
        public int ReadTime { get; set; } // 閱讀時間（以分鐘為單位）
        public string AuthorBio { get; set; } // 作者簡介
        public List<BlogContent> RelatedPosts { get; set; } // 相關文章
        public string ShareLinks { get; set; } // 分享連結
        public DateTime UpdatedDate { get; set; } // 更新日期*/
    }
}
