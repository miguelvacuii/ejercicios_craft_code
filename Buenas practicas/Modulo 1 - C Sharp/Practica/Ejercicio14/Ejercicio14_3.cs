using System;
using Modulo1.Ejercicio14.Utils;

namespace Modulo1.Ejercicio14
{
    public class Video
    {
        private VideoId id;
        private VideoTitle title;
        private VideoDescription description;
        private VideoAuthor author;
        private VideoCreatedAT createdAt;

        private Video(
            VideoId id,
            VideoTitle title,
            VideoDescription description,
            VideoAuthor author,
            VideoCreatedAT createdAt
        ) {
            this.id = id;
            this.title = title;
            this.description = description;
            this.author = author;
            this.createdAt = createdAt;
        }
    }
}
