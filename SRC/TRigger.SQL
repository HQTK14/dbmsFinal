
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