using NotesAppSqlServer.BusinessLayer.Interface;
using NotesAppSqlServer.BusinessLayer.Services.Repository;
using NotesAppSqlServer.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesAppSqlServer.BusinessLayer.Services
{
    public class NoteService : INoteService
    {
        //create local instance 
        private readonly INoteRepository _repositary;

        public NoteService(INoteRepository repositary)
        {
            _repositary = repositary;
        }

        //Get Notes and retrun list of notes
        public async Task<IEnumerable<Note>> ReadAsync()
        {
            //Do code here
            throw new NotImplementedException();
        }
        //Create notes
        public async Task<Note> CreateAsync(Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }
        //Update Notes
        public async Task<Note> UpdateAsync(Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }
        //Delete Notes 
        public async Task<Note> DeleteAsync(Note notes)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
