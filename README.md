# Email-Service-Provider

This project is a simple email sending service built using **ASP.NET Core** and the **MailKit** library. It provides a RESTful API to send emails with optional attachments.
![Screenshot 2025-05-28 182423](https://github.com/user-attachments/assets/af649ec9-e0a3-4d20-998b-94fdc6e84448)

## Features

- Send emails via POST API.
- Support for attachments using `multipart/form-data`.
- Easy integration with other systems or frontend applications.
- Swagger documentation for testing and development.

## Technologies Used

- ASP.NET Core Web API
- MailKit (for sending emails)
- Swagger UI (for API documentation and testing)

## API Endpoint

### POST `/api/Email/Send`

**Content Type:** `multipart/form-data`

#### Parameters

| Name         | Type   | Description                   |
|--------------|--------|-------------------------------|
| ToEmail      | string | Recipient email address       |
| Subject      | string | Subject of the email          |
| Body         | string | Content/body of the email     |
| Attachments  | file[] | Optional file attachments     |

#### Example cURL

```bash
curl -X POST "http://localhost:7121/api/Email/Send" \
  -H "accept: */*" \
  -H "Content-Type: multipart/form-data" \
  -F "ToEmail=example@example.com" \
  -F "Subject=Test Email" \
  -F "Body=Hello from ASP.NET!" \
  -F "Attachments=@file1.txt"
