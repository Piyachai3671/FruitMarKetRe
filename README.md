ระบบตลาดซื้อขายผลไม้ เป็นระบบที่เริ่มพัฒนาตั้งแต่วันที่ 14 พฤษจิกายน 2565 จนถึงวันที่ 17 กุมภาพันธ์ 2566
เป็นโปจเจคจบการศึกษา ระดับชั้นปีที่ 4 

เครื่องมือที่ใช้
- HTML CSS Boostrap5 RadzenComponent Fontawesome สำหรับการออกแบบหน้า UX/UI
- C# สำหรับควบคุมการทำงาน
- SQL Serverr 2014 สำหรับบันทึกข้อมูล
- SoucrceTree Github จุดเซฟ
ระบบซื้อขายสามารถทำงานดังนี้

ส่วนของลูกค้า

![Screenshot 2023-02-09 153833](https://user-images.githubusercontent.com/105155094/219531415-491b527d-41cd-4a4b-81b6-c384961a6c95.png)
![Screenshot 2023-02-09 155047](https://user-images.githubusercontent.com/105155094/219531720-8b82077b-b801-492a-aded-71c5b8be109b.png)
![Screenshot 2023-02-09 155058](https://user-images.githubusercontent.com/105155094/219531755-967d3ed5-af17-4dc5-9fee-3bba8a12d348.png)
![Screenshot 2023-02-09 155143](https://user-images.githubusercontent.com/105155094/219531765-69bc78d0-0db6-4a19-b689-329ab9d2b706.png)

เมื่อผู้ใช้งานเข้ามาในระบบ สิ่งที่สามารถทำได้คือการเลือกดูร้านค้ากับสินค้าที่ปรากฏ แต่ไม่สามารถเพิ่มสินค้าลงในตระกร้าได้ จนกว่าจะมีผู้ใช้งานเข้าสู่ระบบด้วยสถานะลูกค้า

![Screenshot 2023-02-09 153923](https://user-images.githubusercontent.com/105155094/219532063-5a1772a2-3d69-47d5-80e7-9dfe349cb549.png)
![Screenshot 2023-02-09 153955](https://user-images.githubusercontent.com/105155094/219532069-3d393d2a-d0da-47ca-bc1d-7a107510bf4e.png)
![Screenshot 2023-02-09 154028](https://user-images.githubusercontent.com/105155094/219532073-271b64a0-9556-45db-bd49-7976d2f8b5f0.png)

ก่อนทำการเข้าสู่ระบบต้องทำการลงทะเบียนสมาชิก โดยให้เลือกระหว่างร้านค้า หรือลูกค้าเพราะจะมีการบันทึกสถานะผู้ใช้ แต่ละรหัสผู้ใช้งานไม่เหมือนกัน

![Screenshot 2023-02-09 155359](https://user-images.githubusercontent.com/105155094/219532810-4df8b0c6-77cd-4d6d-803d-f7809923b83f.png)

สิ่งที่ต้องทำหลังจากเข้าสู่ระบบ ลูกค้าต้องทำการเพิ่มที่อยู่จัดส่ง มิฉะนั้นจะไม่สามารถกดสั่งซื้อได้ เพราะร้านค้าจะไม่ทราบที่อยู่จัดส่งหากมีคำสั่งซื้อ

![Screenshot 2023-02-09 155330](https://user-images.githubusercontent.com/105155094/219533270-ca58a220-9402-4dc8-a0ed-2dcd1f6e02c4.png)

เมื่อเข้าสู่ระบบเรียบร้อยแล้ว ถึงจะสามารถเลือกสินค้าใน แต่ละร้านค้าได้ หากคลิกเพิ่มสินค้าเดิมที่มีอยู่ในฐานข้อมูลระบบจะเก็บจำนวนสินค้านั้นเพิ่มขึ้นทีละ 1

![Screenshot 2023-02-09 155826](https://user-images.githubusercontent.com/105155094/219533364-a5b0b0c2-ce6f-4d1e-9abb-a65d7b2c1c74.png)

ตระกร้าร้านค้าเกิดจากลูกค้าที่เพิ่มสินค้าในร้านค้าใดร้านหนึ่งจะต้องเลือกร้านค้าเพียง 1 ร้าน ต่อการสั่งซื้อ 1 ครั้ง

![Screenshot 2023-02-09 155841](https://user-images.githubusercontent.com/105155094/219533573-7c29e854-91c9-4ce4-ad05-930792489e0c.png)

เมื่อมาถึงหน้าตระกร้าสินค้าถึงจะสามารถกรอกจำนวนตามที่ต้องการได้ เมื่อมีการกดสั่งซื้อระบบจำลดจำนวนสินค้าคงคลังของร้านค้านั้น และสร้างคำสั่งซื้อ

![Screenshot 2023-02-09 155419](https://user-images.githubusercontent.com/105155094/219534467-5062a43a-644d-4948-976c-648329053f10.png)

หน้าแสดงคำสั่งซื้อจะสามารถค้นหารายการนั้นๆได้ หรือต้องการกรองสถานะก็สามารถทำได้ 
*หมายเหตุ ทุกคำสั่งซื้อจะเก็บชื่อที่อยู่ลูกค้า กับชื่อร้านค้า ราคาสินค้า ไว้ในคำสั่งซื้อหากมีการแก้ไข ข้อมูลส่วนนี้ในคำสั่งซื้อจะไม่มีการเปลี่ยนแปลง

![Screenshot 2023-02-09 155440](https://user-images.githubusercontent.com/105155094/219534598-8a75ba6f-e3b3-4022-871f-43c9793d01fb.png)

สถานะคำสั่งซื้อสถานะแรก คือคำสั่งซื้อที่มีสถานะยังไม่ชำระ จะต้องทำการอัพโหลดภาพการชำระเงินก่อน ถึงจะมีสิทธิ์เปลี่ยนสถานะถัดไปได้ หากต้องการยกเลิก สถานะยังไม่ชำระสามารถทำได้ทั้ง 2 ฝ่าย

![Screenshot 2023-02-09 155515](https://user-images.githubusercontent.com/105155094/219534872-ec56c3a2-ee3f-4e73-997b-3d726ae625e5.png)

เมื่อชำระแล้วสถานะคำสั่งซื้อจะถูกเปลี่ยนเป็นชำระแล้ว ในสถานะนี้ลูกค้าต้องรอทางร้านค้ากรอกเลขพัสดุ สถานะถึงจะถูกเปลี่ยนเป็นสำเร็จ 

![Screenshot 2023-02-09 155614](https://user-images.githubusercontent.com/105155094/219534881-201dbc4e-d851-4829-9b1f-3b6162a35a7f.png)

เมื่อมีเลขพัสดุในคำสั่งซื้อแปลว่าคำสั่งซื้อ มีสถานะเป็นสำเร็จแล้ว จากนั้นระบบจะเพิ่มรายงานของคำสั่งซื้อนั้น

![Screenshot 2023-02-09 155646](https://user-images.githubusercontent.com/105155094/219535668-f5e6281f-4186-4c4e-a88a-826a8b2f9efb.png)

กรณีตัวอย่างคำสั่งซื้อเป็นยกเลิกโดยยังไม่ชำระเงิน จากร้านค้า หรือลูกค้า

![Screenshot 2023-02-09 155720](https://user-images.githubusercontent.com/105155094/219535854-2bbddd48-c29a-4fb4-9017-511b4b952165.png)
![Screenshot 2023-02-09 155755](https://user-images.githubusercontent.com/105155094/219535858-4898db5c-3e65-40e0-aba2-e37131a02b8f.png)

รายงานคำสั่งซื้อจะเกิดขึ้นเมื่อคำสั่งซื้อมีสถานะเป็นสำเร็จแล้ว เท่านั้น และสามารถเข้าไปดูรายละเอียดรายงานคำสั่งซื้อนั้นได้

###ส่วนของร้านค้า###

![Screenshot 2023-02-09 160201](https://user-images.githubusercontent.com/105155094/219538599-01a01a23-5c40-4956-b76f-484be183e73e.png)
![Screenshot 2023-02-09 160213](https://user-images.githubusercontent.com/105155094/219538619-59472fda-dcab-4c41-9c8c-d0f82b8745ff.png)


หน้าหลักของร้านค้าจะเป็นหน้าจำลองเหมือนในมุมที่ลูกค้าเห็นเมื่อลูกค้าทำการเข้ามาในร้านค้า ร้านค้าจะสามารถทำการลงขายสินค้าได้เพียงอย่างเดียว ไม่สามารถทำการสั่งซื้อได้

![Screenshot 2023-02-09 160237](https://user-images.githubusercontent.com/105155094/219538240-384d3361-2139-4298-817c-9e1ea26a4c8a.png)

ร้านค้าจะต้องทำการเพิ่มบัญชีธนาคารก่อน มิฉะนั้นจะไม่สามารถลงขายสินค้าได้

![Screenshot 2023-02-09 160259](https://user-images.githubusercontent.com/105155094/219538738-dee19432-1277-4340-9004-1d547bd61548.png)

การเพิ่มสินค้าจะมีให้เพิ่มรูปภาพได้ 1 รูปภาพต่อจำนวนสินค้าเนื่องจากเวลาที่ไม่เพียงพอ จึงจำเป็นต้องหยุดที่เท่านี้เนื่องจากอาจส่งผลกระทบการทำงานของส่วนอื่นในระบบ อาจเกิดบัคส่วนอื่นๆได้ ถึงแม้จะมีเพียง 1 รูปภาพการก็ไม่ค่อยมีผลกระทบต่อการซื้อมากนักเพราะผลไม้ทุกๆมุมก็เหมือนกัน และจำนวนผลไม้ค่อยข้างมากแต่ละลูกต่างกันเป็นเรื่องธรรมดา

*หมายเหตุสถานะของสินค้าหมายถึง ต้องการแสดงสินค้าเพิ่มให้ลูกค้าสามารถสั่งซื้อได้ หากทำการปิดลูกค้าจะไม่สามารถซื้อสินค้านั้นได้

![Screenshot 2023-02-09 160315](https://user-images.githubusercontent.com/105155094/219539219-dea18c7a-6464-4249-b4cd-c75d03c18708.png)

การแก้ไขสินค้าจะสามารถแก้ไขข้อมูลเดิมที่มีอยู่ 

![Screenshot 2023-02-09 160349](https://user-images.githubusercontent.com/105155094/219539804-f4412bc3-a0ba-434c-b26d-12d0643ece87.png)

สถานะตำสั่งซื้อที่เกิดจากลูกค้าทำการสั่งซื้อ

![Screenshot 2023-02-09 160535](https://user-images.githubusercontent.com/105155094/219539855-4e38226e-dd35-4c77-b8b5-a88cd0a56a93.png)

คำสั่งซื้อที่ยังไม่ชำระเงิน ร้านค้าสามารถทำการยกเลิกเองได้เหมือนลูกค้า

![Screenshot 2023-02-09 160829](https://user-images.githubusercontent.com/105155094/219539944-e86de607-f2c2-43bf-baab-865f5a69067e.png)
![Screenshot 2023-02-09 160702](https://user-images.githubusercontent.com/105155094/219539960-6c7c6c98-b2a9-4abd-936c-e60217d86566.png)

คำสั่งซื้อที่มีการชำระเงิน แล้วร้านค้าต้องทำการเปลี่ยนสถานะคำสั่งซื้อโดยการเพิ่มเลขพัสดุ และยืนยันคำสั่งซื้อเพื่อเปลี่ยนสถานะเป็นสำเร็จ หากต้องการยกเลิกคำสั่งซื้อร้านค้าสามารถยกเลิกได้เมือมีความจำเป็น เช่นกรณีไม่มีสินค้า ร้านค้าจะต้องติดต่อกับลูกค้ากันเอง

![Screenshot 2023-02-09 160844](https://user-images.githubusercontent.com/105155094/219540237-ea7342cb-a4b4-4b01-b394-adb309d03f92.png)

เมื่อคำสั่งซื้อสำเร็จจะมีการเพิ่มรายงานคำสั่งซื้อ

![Screenshot 2023-02-09 160920](https://user-images.githubusercontent.com/105155094/219540318-b69b8ea7-5006-4aef-a7bf-482a90904491.png)

รายงานคำสั่งซื้อ
