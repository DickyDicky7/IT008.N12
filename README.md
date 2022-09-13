<!DOCTYPE html>
<html>

<body class="stackedit">
  <div class="stackedit__html"><h1 id="file-structure"><strong>File Structure</strong></h1>
<p>Tất cà những file liên quan sẽ nằm trong folder Music</p>
<ul>
<li>
<p><strong>Folder Images</strong><br>
– Chứa tất cả các ảnh thumbnail<br>
– Chứa 1 file database định dạng .txt (database_images.txt), mỗi dòng trong database lưu &lt;đường dẫn file nhạc&gt; - &lt; đường dẫn file image&gt;</p>
</li>
<li>
<p><strong>Các folder bắt đầu bằng cụm Playlist_*</strong><br>
– Chứa các file nhạc trong playlist đó</p>
</li>
</ul>
<h1 id="components"><strong>Components</strong></h1>
<h2 id="mediacontroller"><em>1. MediaController</em></h2>
<ul>
<li>
<p><em><strong>Chức năng</strong></em><br>
– Chơi 1 bản media<br>
– Chơi 1 playlist<br>
– Lặp lại 1 bản media hoặc playlist<br>
– Chơi ngẫu nhiên 1 bản media<br>
– Chơi ngẫu nhiên 1 bản media trong playlist<br>
– Skip 10s bản media đang chơi<br>
– Back 10s bản media đang chơi<br>
– Chỉnh âm lượng<br>
– Có 1 thanh bể track bản media đã chơi tới đâu (kèm theo chức năng chơi bản media ở 1 vị trí cụ thể trên thanh)</p>
</li>
<li>
<p><em><strong>Giao diện</strong></em><br>
– Cơ bản giống như thế này:<br>
<img src="https://scontent.fsgn13-2.fna.fbcdn.net/v/t1.15752-9/305530780_1757712781272532_4466138376861634112_n.jpg?_nc_cat=106&amp;ccb=1-7&amp;_nc_sid=ae9488&amp;_nc_ohc=O3V30fuVBpQAX9Ihhsr&amp;_nc_ht=scontent.fsgn13-2.fna&amp;oh=03_AVJIdoZoSRbXOM-UykoZNK6oly7k1T1WzNlDpF12jnxncg&amp;oe=6345A4C4" alt="enter image description here"></p>
</li>
</ul>
<h2 id="mediaitemlist--mediaitem--playlistitem"><em><strong>2. MediaItemList + MediaItem + PlaylistItem</strong></em></h2>
<ul>
<li>
<p><em><strong>MediaItem - Chức năng</strong></em><br>
– Hiển thị thông tin của 1 bản media (name, image, duration)<br>
– Khi click trái chuột sẽ nạp bản media vào MediaController<br>
– Khi click phải chuột sẽ hiện một ContextMenuStrip có một lựa chọn là thay đổi image của media</p>
</li>
<li>
<p><em><strong>MediaItemList - Chức năng</strong></em><br>
– Chứa các bản media<br>
– Chia làm 2 loại: 1 là show tất cả các bản media, 2 là show tất cả các playlist (khi người dùng click vào 1 playlist bất kì thì show tất cả các bản media có trong playlist đó + bắt đầu chơi bản playlist đó)<br>
– Có khả năng view các bản media, playlist theo các hình dáng khác nhau (Tương tự chức năng view của file explorer)</p>
</li>
<li>
<p><em><strong>PlaylistItem - Chức năng</strong></em><br>
– Khi click trái chuột sẽ nạp playlist vào MediaController<br>
– Khi click phải chuột sẽ hiện một ContextMenuStrip có 2 lựa chọn là thay đổi image của playlist và rename lại playlist</p>
</li>
</ul>
<blockquote>
<p><em><strong>Lưu ý: Trường hợp dò database_images.txt không có kết quả thì set image default cho media hoặc playlist (VD: media.default.png, playlist.default.png) và không cần lưu lại vào database</strong></em></p>
</blockquote>
<ul>
<li><em><strong>Giao diện</strong></em><br>
– Giống phần Daily Mix với Playlists, những phần còn lại không cần quan tâm<br>
<img src="https://scontent.fhan4-1.fna.fbcdn.net/v/t1.15752-9/305957206_763206844892061_5038020268857184816_n.png?_nc_cat=105&amp;ccb=1-7&amp;_nc_sid=ae9488&amp;_nc_ohc=hPHIqLSWvbkAX9TbpDJ&amp;_nc_ht=scontent.fhan4-1.fna&amp;oh=03_AVIVOyAOcJNWpj41mA21dG8L9SrOlXVCtvdNwufs0k3kBw&amp;oe=63470227" alt="enter image description here"></li>
</ul>
<h2 id="soundvisualizer"><em><strong>3. SoundVisualizer</strong></em></h2>
<p>Phần này để nhóm trưởng tìm hiểu thêm (Dự định dùng lib CSAudioVisualiztion)</p>
<h1 id="api"><strong>API</strong></h1>
<ul>
<li>
<p><strong>MediaController sẽ giao tiếp với MediaItemList + MediaItem + PlaylistItem thông qua 2 method của MediaController là LoadPlaylist và LoadMedia</strong></p>
</li>
<li>
<p><strong>Phần còn lại sẽ do người phụ trách từng component code theo ý thích của mình</strong></p>
</li>
<li>
<p><strong>Phần bên trên là cốt lõi, nếu ai có sáng tạo hay ý tưởng gì hay hơn thì code thêm</strong></p>
</li>
</ul>
<blockquote>
<p><strong>Nếu có trục trặc liền báo ngay trên messenger</strong></p>
</blockquote>
<h1 id="phân-công-công-việc"><strong>Phân công công việc</strong></h1>
<ul>
<li>Component 1 - 1 người</li>
<li>Component 2 - 2 người</li>
<li>Component 3 - nhóm trưởng</li>
</ul>
<blockquote>
<p><strong>Ai muốn làm việc gì thì báo trên messenger</strong></p>
</blockquote>
<h1 id="vote-bảng-màu"><strong>Vote bảng màu</strong></h1>
<ol>
<li>
<p><a href="https://coolors.co/palette/e63946-f1faee-a8dadc-457b9d-1d3557">https://coolors.co/palette/e63946-f1faee-a8dadc-457b9d-1d3557</a></p>
</li>
<li>
<p><a href="https://coolors.co/palette/386641-6a994e-a7c957-f2e8cf-bc4749">https://coolors.co/palette/386641-6a994e-a7c957-f2e8cf-bc4749</a></p>
</li>
<li>
<p><a href="https://coolors.co/palette/f8f9fa-e9ecef-dee2e6-ced4da-adb5bd-6c757d-495057-343a40-212529">https://coolors.co/palette/f8f9fa-e9ecef-dee2e6-ced4da-adb5bd-6c757d-495057-343a40-212529</a></p>
</li>
</ol>
</div>
</body>

</html>
