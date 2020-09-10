//using NotesAppSqlServer.BusinessLayer.Interface;
using NotesAppSqlServer.BusinessLayer.Interface;
using NotesAppSqlServer.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NotesAppSqlServer.Controllers
{
    public class NoteController : ApiController
    {
        //create local instance
        private readonly INoteService Service;

        public NoteController(INoteService service)
        {
            this.Service = service;
        }

        // GET: api/Note
        //This Method Gets Request Call from User to Read Notes.
        [HttpGet]
        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            //Do code here
            throw new NotImplementedException();
        }

        // POST: api/Notes
        //This Method Gets Request Call from User to Create Notes.
        [HttpPost]
        public async void SubmitNotes([FromBody] Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }

        // PUT: api/Notes/5
        //This Method Gets Request Call from User to Update Notes.
        [HttpPut]
        public async void UpdateNotes([FromBody] Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }

        // DELETE: api/ApiWithActions/5
        //This Method Gets Request Call from User to Delete Notes.
        [HttpDelete]
        public async void DeleteNotes([FromBody] Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
