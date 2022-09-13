# **File Structure**

Tất cà những file liên quan sẽ nằm trong folder Music

- **Folder Images**
-- Chứa tất cả các ảnh thumbnail
-- Chứa 1 file database định dạng .txt (database_images.txt), mỗi dòng trong database lưu <đường dẫn file nhạc> - < đường dẫn file image> 

- **Các folder bắt đầu bằng cụm Playlist_\***
-- Chứa các file nhạc trong playlist đó

# **Components**

## *1. MediaController*

- ***Chức năng***
-- Chơi 1 bản media
-- Chơi 1 playlist
-- Lặp lại 1 bản media hoặc playlist
-- Chơi ngẫu nhiên 1 bản media
-- Chơi ngẫu nhiên 1 bản media trong playlist 
-- Skip 10s bản media đang chơi
-- Back 10s bản media đang chơi
-- Chỉnh âm lượng
-- Có 1 thanh bể track bản media đã chơi tới đâu (kèm theo chức năng chơi bản media ở 1 vị trí cụ thể trên thanh)

- ***Giao diện***
-- Cơ bản giống như thế này:
![enter image description here](https://scontent.fsgn13-2.fna.fbcdn.net/v/t1.15752-9/305530780_1757712781272532_4466138376861634112_n.jpg?_nc_cat=106&ccb=1-7&_nc_sid=ae9488&_nc_ohc=O3V30fuVBpQAX9Ihhsr&_nc_ht=scontent.fsgn13-2.fna&oh=03_AVJIdoZoSRbXOM-UykoZNK6oly7k1T1WzNlDpF12jnxncg&oe=6345A4C4)

## ***2. MediaItemList + MediaItem + PlaylistItem***

- ***MediaItem - Chức năng***
-- Hiển thị thông tin của 1 bản media (name, image, duration)
-- Khi click trái chuột sẽ nạp bản media vào MediaController
-- Khi click phải chuột sẽ hiện một ContextMenuStrip có một lựa chọn là thay đổi image của media

- ***MediaItemList - Chức năng***
-- Chứa các bản media
-- Chia làm 2 loại: 1 là show tất cả các bản media, 2 là show tất cả các playlist (khi người dùng click vào 1 playlist bất kì thì show tất cả các bản media có trong playlist đó + bắt đầu chơi bản playlist đó)
-- Có khả năng view các bản media, playlist theo các hình dáng khác nhau (Tương tự chức năng view của file explorer)

- ***PlaylistItem - Chức năng***
-- Khi click trái chuột sẽ nạp playlist vào MediaController
-- Khi click phải chuột sẽ hiện một ContextMenuStrip có 2 lựa chọn là thay đổi image của playlist và rename lại playlist

> ***Lưu ý: Trường hợp dò database_images.txt không có kết quả thì set image default cho media hoặc playlist (VD: media.default.png, playlist.default.png) và không cần lưu lại vào database***

- ***Giao diện***
-- Giống phần Daily Mix với Playlists, những phần còn lại không cần quan tâm
![enter image description here](https://scontent.fhan4-1.fna.fbcdn.net/v/t1.15752-9/305957206_763206844892061_5038020268857184816_n.png?_nc_cat=105&ccb=1-7&_nc_sid=ae9488&_nc_ohc=hPHIqLSWvbkAX9TbpDJ&_nc_ht=scontent.fhan4-1.fna&oh=03_AVIVOyAOcJNWpj41mA21dG8L9SrOlXVCtvdNwufs0k3kBw&oe=63470227)

## ***3. SoundVisualizer***

Phần này để nhóm trưởng tìm hiểu thêm (Dự định dùng lib CSAudioVisualiztion)

# **API**

- **MediaController sẽ giao tiếp với MediaItemList + MediaItem + PlaylistItem thông qua 2 method của MediaController là LoadPlaylist và LoadMedia**

- **Phần còn lại sẽ do người phụ trách từng component code theo ý thích của mình**

- **Phần bên trên là cốt lõi, nếu ai có sáng tạo hay ý tưởng gì hay hơn thì code thêm**

> **Nếu có trục trặc liền báo ngay trên messenger**

# **Phân công công việc**

- Component 1 - 1 người
- Component 2 - 2 người
- Component 3 - nhóm trưởng

> **Ai muốn làm việc gì thì báo trên messenger**

# **Vote bảng màu**

1. https://coolors.co/palette/e63946-f1faee-a8dadc-457b9d-1d3557

2. https://coolors.co/palette/386641-6a994e-a7c957-f2e8cf-bc4749

3. https://coolors.co/palette/f8f9fa-e9ecef-dee2e6-ced4da-adb5bd-6c757d-495057-343a40-212529
