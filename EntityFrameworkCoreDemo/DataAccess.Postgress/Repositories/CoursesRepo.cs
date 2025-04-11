using DataAccess.Postgress.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Postgress.Repositories;

public class CoursesRepo
{
    private readonly LearningDbContext _dbContext;
    public CoursesRepo(LearningDbContext dbContext) => _dbContext = dbContext;

    public async Task<List<CourseEntity>> GetAllCoursesAsync()
    {
        return await _dbContext.Courses
            .Include(c => c.Students)
            .Include(c => c.Lessons)
            .ToListAsync();
    }
}


