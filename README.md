# Portfolio Web - ASP.NET Core Portfolio Application

## -Overview
Portfolio Web is a comprehensive ASP.NET Core 9.0 web application designed to showcase developer portfolios.  
It includes a **public-facing portfolio website** and a **secure admin panel** for content management.  
This application provides a professional platform for developers to display their work, skills, and experience.

---

## -Features

### Public Portfolio
- **Hero Section**: Dynamic banner with customizable content  
- **About Section**: Personal details and biography  
- **Resume**: Education and work experience timeline  
- **Skills**: Technical skills with visual representation  
- **Statistics**: Achievement counters and metrics  
- **Testimonials**: Client and colleague references  
- **Projects**: Portfolio projects with categories  
- **Contact Form**: Visitor message submission  
- **Social Media**: Integrated social media links  

### Admin Panel
- **User Management**: Secure authentication system  
- **Content Management**: CRUD operations for all sections  
- **Project Management**: Add, edit, delete portfolio projects  
- **Category Management**: Organize projects by type  
- **Skills Management**: Manage technical skills  
- **Experience Management**: Manage work and education history  
- **Testimonials Management**: Handle client references  
- **Message Management**: View and respond to contact form submissions  

---

## -Technology Stack

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

## -Database Schema

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

## 📸 Screenshots 📸

### Public Portfolio UI  

1. **Home Page** – Landing page with a dynamic hero section and navigation.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/3cf32dd1-1afa-4976-b22f-970c461d4eaf" />
  


2. **About Page** – Personal details, biography, and contact info.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/c0dab5c4-d371-4538-89ba-d661d38d5aab" />


3. **Resume** – Timeline view for **Education** and **Professional Experience**.  
   <img width="1919" height="992" alt="image" src="https://github.com/user-attachments/assets/cedd9ea3-0e89-43ff-a11a-21d600efd690" />


4. **Skills & Statistics** – Visual representation of technical skills and career stats.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/60fae806-b353-40f5-af34-b1c4c1c00b07" />
 

5. **Testimonials** – Client and colleague feedback with ratings.  
   <img width="1920" height="993" alt="image" src="https://github.com/user-attachments/assets/c1c7a6e3-f05d-4af0-be8d-eee27d43926c" />


6. **Projects** – Portfolio projects categorized and displayed.  
   <img width="1919" height="988" alt="image" src="https://github.com/user-attachments/assets/8c0cc7d6-1f1d-4ae6-b413-7266b2485f00" />
  

7. **Contact Page** – Contact form, email, phone number, and location map.  
   <img width="1919" height="985" alt="image" src="https://github.com/user-attachments/assets/97ccc5e8-469b-4729-b0ff-1fd30361286b" />
  

---

### Admin Panel  

1. **Login Page** – Secure authentication for accessing the admin panel.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/c9f938ca-1431-42bc-bb91-21d9f23937a0" />
  

2. **Dashboard** – Overview with statistics, skills average, unread messages, and reviews.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/8d4ce12f-7a32-4710-a726-3f0756a7f9dd" />
  

3. **Category Management** – Create, update, or delete project categories.  
   <img width="1919" height="992" alt="image" src="https://github.com/user-attachments/assets/d180bdfb-3b7b-4001-886f-3830972a590a" />
  

4. **Project Management** – Manage portfolio projects with CRUD operations.  
   <img width="1919" height="994" alt="image" src="https://github.com/user-attachments/assets/8b74aaeb-5cc9-426c-856a-9fa93bf61193" />
  

5. **Skills Management** – Add, update, or delete technical skills with percentages.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/5bdd6c76-07ce-4ddc-9d69-1ab28307111d" />
  

6. **Banner Settings** – Configure homepage banner, name, and title.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/773ebb8e-2df7-40e7-8143-6da456c34d6e" />
  

7. **About Me Settings** – Manage profile image, description, and personal info.  
   <img width="1913" height="991" alt="image" src="https://github.com/user-attachments/assets/aaf701c2-87f9-45de-9c5b-52097c712a94" />
  

8. **Education Management** – Add and edit education history with details.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/20af4187-956b-49be-b1bb-5a7d195e4048" />
  

9. **Experience Management** – Manage professional experiences with CRUD features.  
   <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/f1b2c1da-2cb3-4ce0-a832-d29eabdae3d6" />
  

10. **Message Management** – View, read, and delete visitor messages.  
    <img width="1916" height="992" alt="image" src="https://github.com/user-attachments/assets/b8784629-74ee-42d3-a0b4-af15134b74fa" />
  

11. **Testimonials Management** – Handle client and colleague feedback.  
    <img width="1919" height="991" alt="image" src="https://github.com/user-attachments/assets/f0738c99-7a07-468c-88d3-136eee3f3a10" />
  

12. **Contact Info Settings** – Update address, email, phone, and Google Maps integration.  
    <img width="1919" height="992" alt="image" src="https://github.com/user-attachments/assets/1c31ca60-5a3f-4584-8af5-55cdc535e701" />
  

13. **Profile Management** – Edit username, password, and profile details.  
    <img width="1919" height="993" alt="image" src="https://github.com/user-attachments/assets/1cb77a0d-8f7a-429c-a0bc-360dbf172479" />
  

---

**Emre Okan BAŞKAYA**  
- LinkedIn: [Emre Okan Başkaya](https://www.linkedin.com/in/emre-okan-baskaya/)  



