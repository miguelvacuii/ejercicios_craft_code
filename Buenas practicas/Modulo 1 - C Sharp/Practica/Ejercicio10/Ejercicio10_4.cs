using System;

namespace Modulo1.Ejercicio10
{
    public class Controller
    {
        private Cache cache;
        private EntityManager entityManager;

        public CourseController(Cache cache, EntityManager entityManager)
        {
            this.cache = cache;
            this.entityManager = entityManager;
        }

        protected void SetCache(string key, string value)
        {
            this.cache.Set(key, value);
        }

        protected string GetCache(string key)
        {
            return this.cache.Get(key);
        }

        protected void HasCache(string key)
        {
            this.cache.Has(key);
        }

        protected IRepository GetRespository(string repositoyName)
        {
            return this.entityManager.get(repositoyName);
        }
    }

    public class CourseController : Controller
    {
        public CourseController(Cache cache, EntityManager entityManager) : base(cache, entityManager) {}

        public void GetCourseAction(string courseId)
        {
            string cacheKey = "course-" + courseId;

            if (this.HasCache(cacheKey)) {
                return this.GetCache(cacheKey);
            }

            IRepository courseRepository = this.GetRespository("course");

            return courseRepository.findById(courseId);
        }
    }

    public class ProductController : Controller
    {
        public ProductController(Cache cache, EntityManager entityManager) : base(cache, entityManager) {}
        
        public void GetProductAction(string productId)
        {
            string cacheKey = "product-" + productId;

            if (this.HasCache(cacheKey)) {
                return this.GetCache(cacheKey);
            }

            IRepository productRepository = this.GetRespository("product");

            return productRepository.findById(productId);
        }
    }

}
