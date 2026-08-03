FROM nginx:1.27-alpine

LABEL org.opencontainers.image.title="enterprise-github-actions"
LABEL org.opencontainers.image.description="Sample container used to demonstrate an enterprise Docker build workflow."

COPY index.html /usr/share/nginx/html/index.html

EXPOSE 80

HEALTHCHECK --interval=30s --timeout=3s --start-period=5s --retries=3 \
  CMD wget --quiet --tries=1 --spider http://localhost/ || exit 1