variable "project_name" {
  description = "Name of the sample project."
  type        = string
  default     = "enterprise-github-actions"
}

variable "environment" {
  description = "Environment represented by this example."
  type        = string
  default     = "dev"

  validation {
    condition     = contains(["dev", "test", "prod"], var.environment)
    error_message = "Environment must be dev, test, or prod."
  }
}