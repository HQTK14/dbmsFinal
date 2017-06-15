
 CREATE Trigger CHECK_APPOINT on GV_PHUTRACH_DA
     After Insert
     As Begin
     DECLARE @magv char(7), @maDA int
    Select @magv = i.MaGV,
          @maDA = i.MaDoAn
          FROM inserted i

     If Not Exists(Select MaGV 
                            From GV_PHUTRACH_MON PTM , DOAN DA 
                            Where 
                                (DA.MaDoAn = @maDA
                                 AND
                                 DA.MaMon = PTM.MaMon
                                 AND
                                 PTM.MaGV = @magv
                                 ) 
                                 )
     Begin 
     RAISERROR('Giao vien khong phu trach mon', 16, 1)
     rollback transaction 
     END
     END
     -----------------------------
     CREATE PROC CHECK_EXCEED_NUMBER_Of_GROUP
    
     @MaDoAn INT,
     @KQ INT
      AS
     Begin
     DECLARE @allow_numb INT, @x_numb INT
     SET  @x_numb = (SELECT count(*) from NHOM 
     Where maDA = @MaDoAn )
     
     SET @allow_numb = (Select SLN_ToiDa from DOAN 
     Where  MaDoAn = @MaDoAn)
     if (@x_numb < @allow_numb)
      SET @KQ = 2
      ELSE 
      SET @KQ=1
      END
     -----------------------------
     CREATE PROC CHECK_EXCEED_NUMBER_MEMBER_Of_GROUP
    
     @MaDoAn INT,
     @MaNhom INT,
     @KQ INT OUT
      AS
     Begin
     DECLARE @allow_numb INT, @x_numb INT
     SET  @x_numb = (SELECT count(*) from NHOM 
     Where maDA = @MaDoAn AND MaNhom = @MaNhom )
     
     SET @allow_numb = (Select SLSV_ToiDa from DOAN 
     Where  MaDoAn = @MaDoAn)
     if (@x_numb < @allow_numb)
      SET @KQ = 2
      ELSE 
      SET @KQ=1
      END