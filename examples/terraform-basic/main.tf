terraform {
  required_version = ">= 1.6.0"
}

locals {
  project_name = var.project_name

  common_tags = {
    Environment = var.environment
    ManagedBy   = "terraform"
    Project     = local.project_name
  }
}