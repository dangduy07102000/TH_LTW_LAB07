using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SachServer.Controllers
{
    public class SachController : ApiController
    {
        ///<summary>
        /// Dịch vụ lấy toàn bộ Food
        /// </summary>
 
 
        /// <returns></returns>
        [HttpGet]
        public List<Sach> GetSachLists()
        {
            DBSachDataContext db = new DBSachDataContext();
            return db.Saches.ToList();
        }

        ///<summary>
        /// Dịch vụ lấy 1 Food theo khóa chính nào đó
        /// </summary>
 
 
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public Sach GetSach(int id)
        {
            DBSachDataContext db = new DBSachDataContext();
            return db.Saches.FirstOrDefault(x => x.Id == id);
        }

        //[HttpGet]
        //public Sach GetSach_test(int id)
        //{
        //    DBSachDataContext db = new DBSachDataContext();
        //    return db.Saches.FirstOrDefault(x => x.Id == id);
        //}

        ///<summary>
        /// Dịch vụ này để thêm mới 1 Food, các thông số gửi từ client lên
        /// </summary>
 
 
        /// <param name="name">tên </param>
        /// <param name="type">loại-nhóm</param>
        /// <param name="price">đơn giá</param>
        /// <returns>true thành công, false thất bại</returns>
        [HttpPost]
        public bool InsertNewSach(string type, string content, string author, int price)
        {
            try
            {
                DBSachDataContext db = new DBSachDataContext();
                Sach sach = new Sach();
                sach.Type = type;
                sach.Content = content;
                sach.Author = author;
                sach.Price = price;
                db.Saches.InsertOnSubmit(sach);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///<summary>
        /// Dịch vụ chỉnh sửa thông tin
        /// </summary>
 
 
        /// <param name="id">mã food muốn sửa</param>
        /// <param name="name">tên mới</param>
        /// <param name="type">loại mới</param>
        /// <param name="price">giá mới</param>
        /// <returns></returns>
        [HttpPut]
        public bool UpdateSach(int id, string type, string content, string author, int price)
        {
            try
            {
                DBSachDataContext db = new DBSachDataContext();
                //lấy food tồn tại ra
                Sach sach = db.Saches.FirstOrDefault(x => x.Id == id);
                if (sach == null) return false;//không tồn tại false
                sach.Type = type;
                sach.Content = content;
                sach.Author = author;
                sach.Price = price;
                db.SubmitChanges();//xác nhận chỉnh sửa
                return true;
            }
            catch
            {
                return false;
            }
        }

        ///<summary>
        /// Dịch vụ dùng để xóa Food có id
        /// </summary>


        /// <param name="id">id muốn xóa</param>
        /// <returns></returns>
        [HttpDelete]
        public bool DeleteSach(int id)
        {
            DBSachDataContext db = new DBSachDataContext();
            //lấy food tồn tại ra
            Sach sach = db.Saches.FirstOrDefault(x => x.Id == id);
            if (sach == null) return false;
            db.Saches.DeleteOnSubmit(sach);
            db.SubmitChanges();
            return true;
        }
    }
}
