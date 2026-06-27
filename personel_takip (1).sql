-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 27 Haz 2026, 13:42:38
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `personel_takip`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_kullanicilar`
--

CREATE TABLE `tbl_kullanicilar` (
  `id` int(11) NOT NULL,
  `kullanici_adi` varchar(50) NOT NULL,
  `sifre` varchar(50) NOT NULL,
  `yetki` varchar(20) NOT NULL DEFAULT 'personel'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_kullanicilar`
--

INSERT INTO `tbl_kullanicilar` (`id`, `kullanici_adi`, `sifre`, `yetki`) VALUES
(1, 'admin', '1234', 'admin');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_maaslar`
--

CREATE TABLE `tbl_maaslar` (
  `id` int(11) NOT NULL,
  `personel-id` int(11) NOT NULL,
  `donem` varchar(50) NOT NULL,
  `mesai_saati` int(11) NOT NULL,
  `toplam_tutar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_mesai`
--

CREATE TABLE `tbl_mesai` (
  `id` int(11) NOT NULL,
  `personel-id` int(50) NOT NULL,
  `ad_soyad` varchar(100) NOT NULL,
  `islem-turu` varchar(20) NOT NULL,
  `tarih_saat` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_personeller`
--

CREATE TABLE `tbl_personeller` (
  `id` int(11) NOT NULL,
  `ad_soyad` varchar(100) NOT NULL,
  `tc_no` varchar(50) NOT NULL,
  `telefon` varchar(15) NOT NULL,
  `adres` varchar(100) NOT NULL,
  `departman` varchar(50) NOT NULL,
  `baslama_tarihi` varchar(20) NOT NULL,
  `cinsiyet` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tbl_personeller`
--

INSERT INTO `tbl_personeller` (`id`, `ad_soyad`, `tc_no`, `telefon`, `adres`, `departman`, `baslama_tarihi`, `cinsiyet`) VALUES
(2, 'selen yazıcı', '12345678911', '0567 345 22 22', 'asvalt sokak no 11 dr 5 istanbul', 'İnsan kaynakları', '11.06.2026', 'Kadın'),
(3, 'ekrem koç', '45678123412', '0566 678 99 44', 'çekiç sokak no 23 dr 2 istanbul', 'temizlikçi', '11.06.2026', 'Erkek');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tbl_kullanicilar`
--
ALTER TABLE `tbl_kullanicilar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_maaslar`
--
ALTER TABLE `tbl_maaslar`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_mesai`
--
ALTER TABLE `tbl_mesai`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_personeller`
--
ALTER TABLE `tbl_personeller`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tbl_kullanicilar`
--
ALTER TABLE `tbl_kullanicilar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_maaslar`
--
ALTER TABLE `tbl_maaslar`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_mesai`
--
ALTER TABLE `tbl_mesai`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_personeller`
--
ALTER TABLE `tbl_personeller`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
