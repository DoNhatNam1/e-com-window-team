document.addEventListener("DOMContentLoaded", function(){
    $('#idtab').on('click', function() {
       
        window.location.href = 'http://localhost:3000/configure/upload';
    });
    $(document).ready(function () {
        // Biến để xác định trạng thái IsActive
        let isActive = false;
    
        // Duyệt qua từng hàng trong bảng để kiểm tra trạng thái IsActive
        $('table tbody tr').each(function () {
            // Lấy giá trị IsActive từ cột tương ứng
            isActive = $(this).find('td').eq(2).text().trim() === "True";
            
            // Nếu tìm thấy IsActive là True, thoát vòng lặp
            if (isActive) {
                return false;
            }
        });
    
        // Kiểm tra trạng thái của isActive
        if (isActive) {
            // Nếu IsActive là true, hiển thị nút Đăng xuất và Dashboard, ẩn nút Tạo Mẫu
            const buttons = `
                <button id="logoutButton">Đăng xuất</button>
                <button id="dashboardButton">Dashboard</button>
            `;
            $('#buttonContainer').html(buttons); // Hiển thị các nút trong phần tử #buttonContainer
            $('#idtab').hide(); // Ẩn nút Tạo Mẫu
        } else {
            // Nếu IsActive là false, hiển thị lại nút Tạo Mẫu và ẩn các nút Đăng xuất, Dashboard
            $('#buttonContainer').html(''); // Xóa các nút Đăng xuất và Dashboard
            $('#idtab').show(); // Hiển thị lại nút Tạo Mẫu
        }
    });
    
})