DROP TABLE IF EXISTS `tbl_agen_truk`;
CREATE TABLE `tbl_agen_truk` (
  `id_agen` int(11) NOT NULL AUTO_INCREMENT,
  `nm_agen` varchar(100) NOT NULL,
  `no_telpon` varchar(14) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id_agen`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_kota`;
CREATE TABLE `tbl_kota` (
  `id_kota` int(11) NOT NULL AUTO_INCREMENT,
  `nm_kota` varchar(100) NOT NULL,
  `tarif` int(11) NOT NULL,
  PRIMARY KEY (`id_kota`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_pengguna`;
CREATE TABLE `tbl_pengguna` (
  `id_pengguna` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) NOT NULL,
  `password` text NOT NULL,
  `nm_lengkap` varchar(100) NOT NULL,
  `tipe` enum('Admin','Karyawan','Pemilik') NOT NULL,
  PRIMARY KEY (`id_pengguna`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `tbl_pengguna` (`id_pengguna`, `username`, `password`, `nm_lengkap`, `tipe`) VALUES
(1,	'admin',	'21232f297a57a5a743894a0e4a801fc3',	'admin',	'Admin'),
(2,	'pemilik',	'58399557dae3c60e23c78606771dfa3d',	'Pemilik',	'Pimpinan'),
(3,	'karyawan',	'9e014682c94e0f2cc834bf7348bda428',	'Karyawan',	'Karyawan');

DROP TABLE IF EXISTS `tbl_pengiriman`;
CREATE TABLE `tbl_pengiriman` (
  `id_pengiriman` int(11) NOT NULL AUTO_INCREMENT,
  `nomor_do` varchar(12) NOT NULL,
  `tgl_berangkat` date NOT NULL,
  `tgl_sampai` date NOT NULL,
  `id_supir` int(11) NOT NULL,
  `id_truk` int(11) NOT NULL,
  `id_kota` int(11) NOT NULL,
  `vol_ton` int(11) NOT NULL,
  `vol_sak` int(11) DEFAULT NULL,
  `tarif_ptsp` int(11) NOT NULL,
  `tarif_truk` int(11) NOT NULL,
  `sisa_uang_jalan` int(11) NOT NULL,
  `ket` varchar(255) NOT NULL,
  PRIMARY KEY (`id_pengiriman`),
  UNIQUE KEY `nomor_do` (`nomor_do`),
  KEY `id_kota` (`id_kota`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_supir`;
CREATE TABLE `tbl_supir` (
  `id_supir` int(11) NOT NULL AUTO_INCREMENT,
  `nm_supir` varchar(100) NOT NULL,
  `no_hp` varchar(14) DEFAULT NULL,
  PRIMARY KEY (`id_supir`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


DROP TABLE IF EXISTS `tbl_truk`;
CREATE TABLE `tbl_truk` (
  `id_truk` int(11) NOT NULL AUTO_INCREMENT,
  `nopol` varchar(10) NOT NULL,
  `id_agen` int(11) NOT NULL,
  PRIMARY KEY (`id_truk`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE VIEW `daftar_truk` AS select `a`.`id_truk` AS `id_truk`,`a`.`nopol` AS `nopol`,`a`.`id_agen` AS `id_agen`,`b`.`nm_agen` AS `nm_agen` from (`tbl_truk` `a` join `tbl_agen_truk` `b` on((`a`.`id_agen` = `b`.`id_agen`)));

CREATE VIEW `daftar_pengiriman` AS select `a`.`tgl_berangkat` AS `tgl_berangkat`,`a`.`nomor_do` AS `nomor_do`,`c`.`id_supir` AS `id_supir`,`c`.`nm_supir` AS `nm_supir`,`c`.`no_hp` AS `no_hp`,`b`.`id_truk` AS `id_truk`,`b`.`nopol` AS `nopol`,`b`.`id_agen` AS `id_agen`,`b`.`nm_agen` AS `nm_agen`,`d`.`id_kota` AS `id_kota`,`d`.`nm_kota` AS `nm_kota`,`a`.`tarif_ptsp` AS `tarif`,`a`.`vol_ton` AS `vol_ton`,`a`.`vol_sak` AS `vol_sak`,`a`.`tarif_truk` AS `tarif_truk`,(`d`.`tarif` * `a`.`vol_ton`) AS `harga_ptsp`,(`a`.`tarif_truk` * `a`.`vol_ton`) AS `total_ongkos_jalan`,`a`.`sisa_uang_jalan` AS `sisa_uang_jalan`,((`a`.`tarif_truk` * `a`.`vol_ton`) - `a`.`sisa_uang_jalan`) AS `uang_jalan`,((`d`.`tarif` * `a`.`vol_ton`) - (`a`.`tarif_truk` * `a`.`vol_ton`)) AS `jumlah_margin`,`a`.`tgl_sampai` AS `tgl_sampai`,`a`.`ket` AS `ket` from (((`tbl_pengiriman` `a` join `daftar_truk` `b` on((`a`.`id_truk` = `b`.`id_truk`))) join `tbl_supir` `c` on((`a`.`id_supir` = `c`.`id_supir`))) join `tbl_kota` `d` on((`a`.`id_kota` = `d`.`id_kota`)));
