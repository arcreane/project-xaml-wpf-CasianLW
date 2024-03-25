-- MySQL dump for Tools Manager App

-- Create a database (if it doesn't exist)
CREATE DATABASE IF NOT EXISTS `csharp_toolsapp`;
USE `csharp_toolsapp`;

-- Table structure for 'users'
CREATE TABLE `users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `role` ENUM('Admin', 'Employee') NOT NULL,
  `email` VARCHAR(255) NOT NULL,
  `password` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table structure for 'categories'
CREATE TABLE `categories` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `description` TEXT,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table structure for 'tools'
CREATE TABLE `tools` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  `category_id` INT NOT NULL,
  `status` ENUM('Available', 'InUse', 'Maintenance', 'Broken', 'Stolen', 'Lost') NOT NULL,
  `user_assigned_id` INT DEFAULT NULL,
  `qr_image` TEXT,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`category_id`) REFERENCES `categories`(`id`) ON DELETE CASCADE,
  FOREIGN KEY (`user_assigned_id`) REFERENCES `users`(`id`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table structure for 'qrcodes'
CREATE TABLE `qrcodes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `reference` VARCHAR(255) NOT NULL,
  `tool_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`tool_id`) REFERENCES `tools`(`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Table structure for 'history'
CREATE TABLE `history` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `date_of_change` DATETIME NOT NULL,
  `changed_by_user_id` INT NOT NULL,
  `tool_id` INT NOT NULL,
  `old_status` ENUM('Available', 'InUse', 'Maintenance', 'Broken', 'Stolen', 'Lost') NOT NULL,
  `new_status` ENUM('Available', 'InUse', 'Maintenance', 'Broken', 'Stolen', 'Lost') NOT NULL,
  `new_assigned_user_id` INT DEFAULT NULL,
  PRIMARY KEY (`id`),
  FOREIGN KEY (`changed_by_user_id`) REFERENCES `users`(`id`),
  FOREIGN KEY (`tool_id`) REFERENCES `tools`(`id`),
  FOREIGN KEY (`new_assigned_user_id`) REFERENCES `users`(`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
