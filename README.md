<h1 align="center">
  <a href="https://reactnative.dev/">
    HUBING TECHNOLOGY
  </a>
</h1>

<p align="center">
  <strong>Dự án nghiên cứu khoa học sinh viên (Trường đại học Kinh tế - Luật)
</p>

Dự án [**Phát triển ứng dụng tích hợp dữ liệu sinh viên tại trường Đại học Kinh tế - Luật**][r] Là dự án của nhóm sinh viên khoa Hệ thống thông tin - UEL, Mã nguồn API này được viết nhằm mục đích thử nghiệm tính năng, dữ liệu hoàn toàn được giả lập (không có thật). Các dữ liệu trả về API nhóm thực hiện như sau
- Domain:  <a href="https://uel.azurewebsites.net/">https://uel.azurewebsites.net/</a>
- [**/api/student/**][1] Dữ liệu trả về dạng JSON, hiển thị tất cả sinh viên UEL.
- [**/api/course**][2] Dữ liệu trả về dạng JSON, hiển thị tất cả khoá học tại UEL.
- [**/api/activityscore/{studentId}**][3] Dữ liệu trả về dạng JSON, hiển thị điểm rèn luyện của 1 sinh viên cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/course/{StudentId}**][4] Dữ liệu trả về dạng JSON, hiển thị danh sách môn học đã đăng ký của 1 sinh viên cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/schedule/{studentId}**][5] Dữ liệu trả về dạng JSON, hiển thị danh sách thời gian biểu của 1 sinh viên cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/scoreboard/{studentId}**][6] Dữ liệu trả về dạng JSON, hiển thị danh sách điểm học tập của 1 sinh viên trong tất cả học kỳ cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/testschedule/{studentId}**][7] Dữ liệu trả về dạng JSON, hiển thị danh sách lịch thi của 1 sinh viên trong tất cả học kỳ cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/tuition/{studentId}**][8] Dữ liệu trả về dạng JSON, hiển thị danh sách học phí, số tiền đã đóng, cần đóng của 1 sinh viên trong tất cả học kỳ cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
- [**/api/student/{studentId}**][9] Dữ liệu trả về dạng JSON, hiển thị thông tin cá nhân chi tiết của 1 sinh viên cụ thể bằng cách truyền đối số là mã số sinh viên muốn tra cứu.
  <h4 align="center">
  <a href="/">
    ##Lưu ý: {studentId}  là đối số truyền vào
  </a>
</h4>


[r]: https://uel.azurewebsites.net/
[1]: https://uel.azurewebsites.net/api/student/
[2]: https://uel.azurewebsites.net/api/course
[3]: https://uel.azurewebsites.net/api/activityscore/K204060303
[4]: https://uel.azurewebsites.net/api/course/K204060303
[5]: https://uel.azurewebsites.net/api/schedule/K204060303
[6]: https://uel.azurewebsites.net/api/scoreboard/K204060303
[7]: https://uel.azurewebsites.net/api/testschedule/K204060303
[8]: https://uel.azurewebsites.net/api/tuition/K204060303
[9]: https://uel.azurewebsites.net/api/student/K204060303

## 📋 Yêu cầu dự án

Đây là Public API nên mọi cá nhân, dự án đều có thể sử dụng, tham khảo

## 🎉 Mẫu: Kết quả trả về
- **<a href="https://uel.azurewebsites.net/api/student/">https://uel.azurewebsites.net/api/student/</a>** 
```javascript
[
  {
    "id": "K204060302",
    "dob": "28/01/2002",
    "email": "haint20406c@st.uel.edu.vn",
    "firstName": "Hải",
    "lastName": "Nguyễn Thế ",
    "major": "Hệ thống thông tin quản lý Chất lượng cao khoá 20",
    "selfEmail": "K204060302@gmail.com",
    "selfPhone": "0902820654",
    "town": "Bắc Ninh",
    "yearAdmission": 2020
  },
  {
    "id": "K204060303",
    "dob": "12/02/2002",
    "email": "kimdt20406c@st.uel.edu.vn",
    "firstName": "Kim",
    "lastName": "Đặng Thiên",
    "major": "Hệ thống thông tin quản lý Chất lượng cao khoá 20",
    "selfEmail": "K204060303@gmail.com",
    "selfPhone": "0386776654",
    "town": "107  ấp Phú Thành, xã Phú Hưng, tp Bến Tre, tỉnh Bến Tre",
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/course/">https://uel.azurewebsites.net/api/course/</a>** 
```javascript
[
  {
    ""id"": ""BC01202024"",
    ""courseName"": ""Báo cáo chuyên đề thực tập"",
    ""credit"": 4
  },
  {
    ""id"": ""CS51202024"",
    ""courseName"": ""Cơ sở văn hóa Việt Nam"",
    ""credit"": 2
}]
```
- **<a href="https://uel.azurewebsites.net/api/activityscore/K204061426">https://uel.azurewebsites.net/api/activityscore/K204061426</a>** 
```javascript
[
{
    "studentId": "K204061426",
    "startYear": 2020,
    "endYear": 2021,
    "semester": 1,
    "score": 80
  },
  {
    "studentId": "K204061426",
    "startYear": 2020,
    "endYear": 2021,
    "semester": 2,
    "score": 90
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/course/K204061426">https://uel.azurewebsites.net/api/course/K204061426</a>** 
```javascript
[
  {
    "studentId": "K204061426",
    "courseId": "IS90202024",
    "courseName": "Giới thiệu ngành (406)",
    "teacherName": "Trương Hoài Phan",
    "semester": 1,
    "startYear": 2020,
    "endYear": 2021
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/schedule/K204061426">https://uel.azurewebsites.net/api/schedule/K204061426</a>** 
```javascript
[
{
    "studentId": "K204061426",
    "dateTime": "2023-01-31T00:00:00",
    "courseName": "Giới thiệu ngành (406)",
    "room": "A.802",
    "gender": 0,
    "teacherName": "Trương Hoài Phan",
    "timeStart": "07:45",
    "timeEnd": "11:50",
    "timeFormat": "AM"
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/scoreboard/K204061426">https://uel.azurewebsites.net/api/scoreboard/K204061426</a>** 
```javascript
[
  {
    "studentId": "K204061426",
    "courseName": "Giới thiệu ngành (406)",
    "attendence": 8,
    "midterm": 8,
    "final": 8,
    "advanced": 0,
    "percentAttendence": 0.3,
    "percentMidterm": 0.2,
    "percentFinal": 0.5,
    "percentAdvanced": 0,
    "startYear": "2020",
    "endYear": "2021",
    "semester": 1,
    "credit": 2
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/testschedule/K204061426">https://uel.azurewebsites.net/api/testschedule/K204061426</a>** 
```javascript
[
  {
    "studentId": "K204061426",
    "courseName": "Cơ sở văn hóa Việt Nam",
    "credit": 2,
    "date": "2020-11-25T00:00:00",
    "room": "A.808",
    "time": "12:00",
    "endYear": 2021,
    "semester": 1,
    "startYear": 2020
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/tuition/K204061426">https://uel.azurewebsites.net/api/tuition/K204061426</a>** 
```javascript
[
  {
    "studentId": "K204061426",
    "tuitionName": "Học phí học kỳ 1",
    "amount": 13900000,
    "amountPaid": 13900000,
    "semester": 1,
    "startYear": 2020,
    "endYear": 2021
  }
]
```
- **<a href="https://uel.azurewebsites.net/api/student/K204061426">https://uel.azurewebsites.net/api/student/K204061426</a>** 
```javascript
{
  "id": "K204061426",
  "dob": "02/01/2002",
  "email": "binhtt20406c@st.uel.edu.vn",
  "firstName": "Bình",
  "lastName": "Trần Thanh",
  "major": "Hệ thống thông tin quản lý Chất lượng cao khoá 20",
  "selfEmail": "K204061426@gmail.com",
  "selfPhone": "0968213964",
  "town": "thôn Phú Hữu 1, xã Ân Tường Tây, huyện Hoài Ân, tỉnh Bình Định",
  "yearAdmission": 2020
}
```
- **<a href="https://uel.azurewebsites.net/api/course/K204061426">https://uel.azurewebsites.net/api/course/K204061426</a>** 
```javascript

[
  {
    "studentId": "K204061426",
    "courseId": "IS90202024",
    "courseName": "Giới thiệu ngành (406)",
    "teacherName": "Trương Hoài Phan",
    "semester": 1,
    "startYear": 2020,
    "endYear": 2021
  }
]
```
