# 🚀 Portfolio Web - ASP.NET Core Portfolio Application

## 🌟 Overview
Portfolio Web is a comprehensive ASP.NET Core 9.0 web application designed to showcase developer portfolios.  
It includes a **public-facing portfolio website** and a **secure admin panel** for content management.  
This application provides a professional platform for developers to display their work, skills, and experience.

---

## ✨ Features

### 🌐 Public Portfolio
- **Hero Section**: Dynamic banner with customizable content  
- **About Section**: Personal details and biography  
- **Resume**: Education and work experience timeline  
- **Skills**: Technical skills with visual representation  
- **Statistics**: Achievement counters and metrics  
- **Testimonials**: Client and colleague references  
- **Projects**: Portfolio projects with categories  
- **Contact Form**: Visitor message submission  
- **Social Media**: Integrated social media links  

### 🔐 Admin Panel
- **User Management**: Secure authentication system  
- **Content Management**: CRUD operations for all sections  
- **Project Management**: Add, edit, delete portfolio projects  
- **Category Management**: Organize projects by type  
- **Skills Management**: Manage technical skills  
- **Experience Management**: Manage work and education history  
- **Testimonials Management**: Handle client references  
- **Message Management**: View and respond to contact form submissions  

---

## 🛠️ Technology Stack

### Backend
- **Framework**: ASP.NET Core 9.0  
- **Database**: SQL Server with Entity Framework Core 9.0.8  
- **Authentication**: Cookie-based authentication  
- **Session Management**: Distributed memory cache  
- **Architecture**: MVC pattern with ViewComponents  

### Frontend
- **CSS Framework**: Bootstrap 5.3.3  
- **Template**: Kelly Bootstrap Template  
- **JavaScript**: Modern ES6+ with Bootstrap components  
- **Responsive Design**: Mobile-first approach  
- **Icons**: Bootstrap Icons  

### Development Tools
- **IDE**: Visual Studio 2022 / VS Code  
- **Package Manager**: NuGet  
- **Version Control**: Git  
- **Database Tools**: SQL Server Management Studio  

---

---

## 🗄️ Database Schema

### Core Entities
- **User**: Authentication data  
- **Project**: Portfolio projects  
- **Category**: Project categories  
- **Skill**: Technical skills  
- **Education**: Education history  
- **Experience**: Professional work experience  
- **Testimonial**: Client/colleague feedback  
- **ContactInfo**: Contact details  
- **UserMessage**: Visitor messages  

### Relations
- **One-to-Many**: Category → Projects  
- **Navigation Properties** for easier EF Core queries  
- **Validation** with Data Annotations  

---

## 📸 Screenshots  

### 🌐 Public Portfolio UI  

1. **Home Page** – Landing page with a dynamic hero section and navigation.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/3cf32dd1-1afa-4976-b22f-970c461d4eaf" />
  

2. **About Page** – Personal details, biography, and contact info.  
   ![About](./screenshots/ui-about.png)  

3. **Resume** – Timeline view for **Education** and **Professional Experience**.  
   ![Resume](./screenshots/ui-resume.png)  

4. **Skills & Statistics** – Visual representation of technical skills and career stats.  
   ![Skills](./screenshots/ui-skills.png)  

5. **Testimonials** – Client and colleague feedback with ratings.  
   ![Testimonials](./screenshots/ui-testimonials.png)  

6. **Projects** – Portfolio projects categorized and displayed.  
   ![Projects](./screenshots/ui-projects.png)  

7. **Contact Page** – Contact form, email, phone number, and location map.  
   ![Contact](./screenshots/ui-contact.png)  

---

### 🔐 Admin Panel  

1. **Login Page** – Secure authentication for accessing the admin panel.  
   ![Login](./screenshots/admin-login.png)  

2. **Dashboard** – Overview with statistics, skills average, unread messages, and reviews.  
   ![Dashboard](./screenshots/admin-dashboard.png)  

3. **Category Management** – Create, update, or delete project categories.  
   ![Categories](./screenshots/admin-categories.png)  

4. **Project Management** – Manage portfolio projects with CRUD operations.  
   ![Projects](./screenshots/admin-projects.png)  

5. **Skills Management** – Add, update, or delete technical skills with percentages.  
   ![Skills](./screenshots/admin-skills.png)  

6. **Banner Settings** – Configure homepage banner, name, and title.  
   ![Banner](./screenshots/admin-banner.png)  

7. **About Me Settings** – Manage profile image, description, and personal info.  
   ![About](./screenshots/admin-about.png)  

8. **Education Management** – Add and edit education history with details.  
   ![Education](./screenshots/admin-education.png)  

9. **Experience Management** – Manage professional experiences with CRUD features.  
   ![Experience](./screenshots/admin-experience.png)  

10. **Message Management** – View, read, and delete visitor messages.  
    ![Messages](./screenshots/admin-messages.png)  

11. **Testimonials Management** – Handle client and colleague feedback.  
    ![Testimonials](./screenshots/admin-testimonials.png)  

12. **Contact Info Settings** – Update address, email, phone, and Google Maps integration.  
    ![Contact Info](./screenshots/admin-contact.png)  

13. **Profile Management** – Edit username, password, and profile details.  
    ![Profile](./screenshots/admin-profile.png)  

---

## 👨‍💻 Author
**Emre Okan BAŞKAYA**  
- LinkedIn: [Emre Okan Başkaya](https://www.linkedin.com/in/emre-okan-baskaya/)  



