# Hướng dẫn code
## 1 - Hướng dẫn git
- Copy và chạy từng dòng lệnh sau
### 1.1 - Clone và tạo nhánh
- Clone master repository về
```
git clone https://github.com/thuctapnhomt3nguyenhau/QuanLyNhanSu.git
```
- Tạo branch của mình
```
git branch hieunh1801
```
- Checkout sang nhánh của mình (nhảy sang nhánh của mình)
```
git checkout hieunh1801
```
- Code và do something ........
### 1.2 - PUSH code lên nhánh của mình
- Thêm những gì sẽ commit
```
git add .
```
- Commit code: nghĩa là cam kết rằng mình đã tạo ra những thay đổi gì
```
git commit -m "Đã làm xong procedure"
```
- Push code lên trên kho git trên mạng của Hậu, trên branch của mình
```
git push
```
- __Chú ý:__ lần đầu push code lên sẽ xuất hiện dòng lỗi không cho push và nó gợi ý ra một dòng lệnh ==> Copy nguyên và dán vào rồi __enter__.
```
git push --set-upstream orign hieunh1801
```



## 2 - Tạo Procedure trong file Data.sql

- 1. Tạo store procedure __GETALL__: lấy ra tất cả dữ liệu cần hiển thị
- 2. Tạo SP __Insert__ : để thêm dữ liệu
- 3. Tạo SP __Delete__ : xóa dữ liệu - chú ý có những bảng phải xóa nhiều hơn một bảng
- 4. Tạo SP __UPDATE__ : để cập nhật dữ liệu
- 5. Tạo SP __SEARCH__ : để tìm kiếm thông tin

- __===>__ TEST lại 5 procedure vừa tạo.