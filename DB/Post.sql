CREATE TABLE posts (
    id SERIAL PRIMARY KEY,
    author_name VARCHAR(100),
    author_avatar_color VARCHAR(20),
    image_url TEXT,
    created_at TIMESTAMP,
    caption VARCHAR(255)
);

-- 2. สร้างตาราง Comments
CREATE TABLE comments (
    id SERIAL PRIMARY KEY,
    post_id INT REFERENCES posts(id),
    commenter_name VARCHAR(100),
    commenter_avatar_color VARCHAR(20),
    content TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO posts (author_name, author_avatar_color, image_url, created_at)
VALUES ('Change can', '#4472C4', 'https://images.pexels.com/photos/320014/pexels-photo-320014.jpeg', '2021-10-16 16:00:00');