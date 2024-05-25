﻿using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToolsManagerApp.Models;
using Microsoft.Extensions.Logging;

namespace ToolsManagerApp.Repositories
{
    public class ToolRepository : IToolRepository
    {
        private readonly IMongoCollection<Tool> _tools;
        private readonly ILogger<ToolRepository> _logger;

        public ToolRepository(IMongoDatabase database, ILogger<ToolRepository> logger)
        {
            _tools = database.GetCollection<Tool>("Tools");
            _logger = logger;
        }

        public async Task<IEnumerable<Tool>> GetAllToolsAsync()
        {
            return await _tools.Find(tool => true).ToListAsync();
        }

        public async Task<IEnumerable<Tool>> GetToolsByIdsAsync(IEnumerable<string> toolIds)
        {
            var filter = Builders<Tool>.Filter.In(t => t.Id, toolIds);
            return await _tools.Find(filter).ToListAsync();
        }

        public async Task<Tool> GetToolByIdAsync(string id)
        {
            return await _tools.Find(tool => tool.Id == id).FirstOrDefaultAsync();
        }

        public async Task AddToolAsync(Tool tool)
        {
            await _tools.InsertOneAsync(tool);
        }

        public async Task UpdateToolAsync(Tool tool)
        {
            await _tools.ReplaceOneAsync(t => t.Id == tool.Id, tool);
        }

        public async Task DeleteToolAsync(string id)
        {
            await _tools.DeleteOneAsync(tool => tool.Id == id);
        }
    }
}
