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

## Hướng dẫn Merger các nhánh
Step 1: pull code từ trên remote repository về máy
```
git pull
```
Step 2: Xem các nhánh được pull về chưa
```
git branch -r
```
Step 3: Xem trạng thái git của mình
```
git status
```
Step 3.1: Nếu có filt bị thay đổi, thêm sửa hoặc xóa => cần commit
```
git add . // thêm các thay đổi để commit
git commit -m "Tên commit"
```
Step 4: Merger các nhánh
Step 4.1: Về nhánh master trước khi push
```
git checkout master
```
Step 4.1: Vd: merger nhánh origin/Nambui27
```
git merge origin/NamBui27
```
Step 4.2 Bị conflic
- Bước 1: Mở visual studio code lên và chỉnh sủa những file bị conflic
- Bước 2: 
```
git add .
git commit -m "Giải quyết conflic với nhánh Nambui27"
```
Sau khi hoàn thiện tất cả các bước thì push lên orign/master
```
push
```
