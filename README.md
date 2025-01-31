# Waste Sorting App

A Spring Boot application designed to help users sort waste efficiently by providing categorized waste information, disposal guidelines, and recycling tips.

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
  - [Prerequisites](#prerequisites)
  - [Steps](#steps)
- [Usage](#usage)
  - [Running the App](#running-the-app)
  - [Accessing API Documentation](#accessing-api-documentation)
- [API Endpoints](#api-endpoints)
  - [Waste Categories](#waste-categories)
  - [Disposal Guidelines](#disposal-guidelines)
  - [Recycling Tips](#recycling-tips)
- [Entities](#entities)
  - [Waste Category](#waste-category)
  - [Disposal Guidelines](#disposal-guidelines)
  - [Recycling Tips](#recycling-tips)
- [Tech Stack](#tech-stack)

## Introduction

The Waste Sorting App simplifies waste management by categorizing waste, guiding proper disposal, and offering tips for recycling. This app encourages sustainable practices and supports environmental preservation efforts.

## Features

- **Waste Categories**: List and search different waste categories.
- **Disposal Guidelines**: Instructions on how to dispose of specific types of waste.
- **Recycling Tips**: Recommendations to promote recycling and sustainability.

## Installation

### Prerequisites

- Java 11 or higher
- Maven or Gradle
- A database (e.g., MySQL/PostgreSQL)

### Steps

1. Clone the repository:

    ```bash
    git clone https://github.com/yourusername/waste-sorting-app.git
    cd waste-sorting-app
    ```

2. Configure the database in `application.properties`:

    ```properties
    spring.datasource.url=jdbc:mysql://localhost:3306/waste_db
    spring.datasource.username=dbuser
    spring.datasource.password=dbpassword
    ```

3. Build the project:

    ```bash
    mvn clean install
    ```

4. Run the application:

    ```bash
    mvn spring-boot:run
    ```

## Usage

### Running the App

Once the application starts, it will be accessible at:

- **Local Server**: [http://localhost:8080](http://localhost:8080)

### Accessing API Documentation

Navigate to [http://localhost:8080/swagger-ui.html](http://localhost:8080/swagger-ui.html) to view and interact with the API documentation.


